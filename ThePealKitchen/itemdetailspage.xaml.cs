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
    /// Interaction logic for itemdetailspage.xaml
    /// </summary>
    public partial class itemdetailspage : Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        public itemdetailspage()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-4S88VMD;Initial Catalog=ThePealKitchen;Integrated Security=True");
        }

        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Item", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid1.ItemsSource = dt.DefaultView;
            con.Close();
            /*DbClass.openConnection();

            DbClass.sql = "SELECT [Item_ID],[Item_Name],[Price],[Quantity] FROM Item;";
            DbClass.cmd.CommandType = CommandType.Text;
            DbClass.cmd.CommandText = DbClass.sql;

            DbClass.da = new SqlDataAdapter(DbClass.cmd);
            DbClass.dt = new DataTable();
            DbClass.da.Fill(DbClass.dt);

            DataGrid1.ItemsSource = DbClass.dt.DefaultView;


            DbClass.closeConnection();*/
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            ManagerView mi = new ManagerView();
            mi.Show();
        }


    }
}
