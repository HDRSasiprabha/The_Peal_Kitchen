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
    /// Interaction logic for Invoicedetailspage.xaml
    /// </summary>
    public partial class Invoicedetailspage : Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        public Invoicedetailspage()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-4S88VMD;Initial Catalog=ThePealKitchen;Integrated Security=True");
        }
        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Invoice", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid3.ItemsSource = dt.DefaultView;
            con.Close();
            /*DbClass.openConnection();

            DbClass.sql = "SELECT [Inv_ID],[Inv_Date],[Ord_ID],[cstmr_ID] FROM Invoice;";
            DbClass.cmd.CommandType = CommandType.Text;
            DbClass.cmd.CommandText = DbClass.sql;

            DbClass.da = new SqlDataAdapter(DbClass.cmd);
            DbClass.dt = new DataTable();
            DbClass.da.Fill(DbClass.dt);

            DataGrid3.ItemsSource = DbClass.dt.DefaultView;


            DbClass.closeConnection();*/
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            ManagerView min = new ManagerView();
            min.Show();

        }

        private void DataGrid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
