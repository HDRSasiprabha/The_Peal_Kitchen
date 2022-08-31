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
    /// Interaction logic for Orderdetailspage.xaml
    /// </summary>
    public partial class Orderdetailspage : Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        public Orderdetailspage()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-4S88VMD;Initial Catalog=ThePealKitchen;Integrated Security=True");
        }
        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Orders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid4.ItemsSource = dt.DefaultView;
            con.Close();

            /*DbClass.openConnection();

            DbClass.sql = "SELECT [Order_ID],[Order_Date],[No_of_items],[CID],[EMP_ID] FROM Orders;";
            DbClass.cmd.CommandType = CommandType.Text;
            DbClass.cmd.CommandText = DbClass.sql;

            DbClass.da = new SqlDataAdapter(DbClass.cmd);
            DbClass.dt = new DataTable();
            DbClass.da.Fill(DbClass.dt);

            DataGrid4.ItemsSource = DbClass.dt.DefaultView;


            DbClass.closeConnection();*/
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            ManagerView mo = new ManagerView();
            mo.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
