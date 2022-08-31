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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ThePealKitchen.Manager_View_Images;

namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for Customerdetailspage.xaml
    /// </summary>
    public partial class Customerdetailspage : Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        public Customerdetailspage()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-4S88VMD;Initial Catalog=ThePealKitchen;Integrated Security=True");
        }

        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select  Customer_ID ,Name ,Email,TP,Address from Customers", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid2.ItemsSource = dt.DefaultView;
            con.Close();
            /* DbClass.openConnection();

             DbClass.sql = "SELECT [Customer_ID],[Name],[Email],[TP],[Address],[T_ID] FROM Customers;";
             DbClass.cmd.CommandType = CommandType.Text;
             DbClass.cmd.CommandText = DbClass.sql;

             DbClass.da = new SqlDataAdapter(DbClass.cmd);
             DbClass.dt = new DataTable();
             DbClass.da.Fill(DbClass.dt);

             DataGrid2.ItemsSource = DbClass.dt.DefaultView;


             DbClass.closeConnection();*/
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {

            ManagerView mc = new ManagerView();
            mc.Show();
        }
    }
}
