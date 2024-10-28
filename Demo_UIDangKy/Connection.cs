using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo_UIDangKy
{
    internal class Connection
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=LAPTOP-4DGRPIBV;Initial Catalog=DANGKI_DEMO;Integrated Security=True;TrustServerCertificate=True";
            return new SqlConnection(connectionString);
        }
    }
}
