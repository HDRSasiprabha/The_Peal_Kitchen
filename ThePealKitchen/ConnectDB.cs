using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ThePealKitchen
{
   
    class ConnectDB
    {

        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        public ConnectDB() //default constructor 
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        }
        public int save_update_delete(string q)
        {
            con.Open();
            cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static void opencon()
        {
            con.Open();
        }
        public static void closecon()
        {
            con.Close();
        }
        
    }
   
}
