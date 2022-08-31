using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;


namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        SqlConnection con=new SqlConnection();
        SqlCommand com =new SqlCommand();
        SqlDataReader dr;
        public AdminLogin()
        {
            InitializeComponent();
            con=new SqlConnection("Data Source=DESKTOP-4S88VMD;Initial Catalog=ThePealKitchen;Integrated Security=True");
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            
            if (con.State==System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            if(Verifyuser(txt_username.Text,txt_pswrd.Password))
            {
                MessageBox.Show("Press Ok To Continue Manager Panel", "Login Successfully", MessageBoxButton.OK, MessageBoxImage.Information);
                 ManagerView manager = new ManagerView();
                manager.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool Verifyuser(string username,string password)
        {
            con.Open();
            com.Connection = con;
            com.CommandText="select status from Manager where Username = '"+username+"' and Password = '"+password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToBoolean(dr["status"])==true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

