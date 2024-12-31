using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AkilliEvYonetim.Helpers
{
    internal class DatabaseHelpers
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["AkilliEvDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
