using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Demo_UIDangKy
{
    internal class Modify
    {
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        public List<TaiKhoan> TaiKhoans(string query)
        {
            var taiKhoans = new List<TaiKhoan>();
            using (var sqlConnection = Connection.GetSqlConnection())
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return taiKhoans;
        }

        public void Command(string query) // dang ki tai khoan
        {
            using var sqlConnection = Connection.GetSqlConnection();
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
