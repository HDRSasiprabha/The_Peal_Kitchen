using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace ThePealKitchen.Manager_View_Images
{
    class DbClass
    {
        public static string GetConnectionString()
        {
            string strConString = "Data Source=DESKTOP-4S88VMD;Initial Catalog=ThePealKitchen;Integrated Security=True";
            return strConString;
        }
        public static string sql;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader rd;
        public static DataTable dt;
        public static SqlDataAdapter da;

        public static void openConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = GetConnectionString();
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + Environment.NewLine +
                        "" + ex.Message.ToString(), "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public static void closeConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
