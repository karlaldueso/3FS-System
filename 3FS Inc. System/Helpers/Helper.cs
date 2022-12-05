using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using _3FS_System.Helpers;
namespace _3FS_System.Helpers
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            //return config.ConnectionStrings.ConnectionStrings[name].ConnectionString;
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static bool isConnection(string connectionString)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();
            return true;
        }
    }
}
