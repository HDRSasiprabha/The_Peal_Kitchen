using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for UserControlSignin.xaml
    /// </summary>
    public partial class UserControlSignin : UserControl
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public UserControlSignin()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-4S88VMD;Initial Catalog=ThePealKitchen;Integrated Security=True");
        }

        public UserControlSignin(string email,string password)
        {
            InitializeComponent();
        }

        private void btn_QR_Click(object sender, RoutedEventArgs e)
        {
            QR qr = new QR();
            qr.Show();
        }

        private void btn_geni_Click(object sender, RoutedEventArgs e)
        {
            QRgeni qeni = new QRgeni();
            qeni.Show();
        }

      
        private bool Verifyuser(string email,string password)
        {
           
                con.Open();
                com.Connection = con;
                com.CommandText = "select status from Customers where Email = '" + email + "' and cus_password = '" + password + "'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (Convert.ToBoolean(dr["status"]) == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            return false;
        
        }

        private void keyboard_login_Click(object sender, RoutedEventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            if (Verifyuser(Txtemail.Text, TxtPassword.Password))
            {
                string Name = Txtemail.Text;
                App.Current.Properties["NameOfProperty"] = Name;
                Cart_invoice_window cart = new Cart_invoice_window();
                //NavigationService.(cart);
                
                MessageBox.Show("Press Ok To Continue ", "Login Successfully", MessageBoxButton.OK, MessageBoxImage.Information);
                cart.Show();
            }
            else
            {
                MessageBox.Show("Email or Password is incorrect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
