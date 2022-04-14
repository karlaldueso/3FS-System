using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionToSQL.DB_Helper
{
    public static class DBHelper
    {
        public static MySqlConnection conn;
        public static MySqlCommand cmd = null;
        public static DataTable dt;
        public static MySqlDataAdapter sda;

        public static void EstablishConnection(string name)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "127.0.0.1";
                builder.UserID = "root";
                builder.Password = "ab&j";
                builder.Database = name;
                builder.SslMode = MySqlSslMode.None;
                conn = new MySqlConnection(builder.ToString());
                MessageBox.Show("Database connection successfull!", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
