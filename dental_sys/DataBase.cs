using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace dental_sys
{
    class DataBase
    {        SqlConnection sqlConnection = new SqlConnection (@"Data Source=DESKTOP-7ERBN6I\SQLEXPRESS;Initial Catalog=dentistry;Integrated Security=True");

 public void openconnection()
        {
            if (sqlConnection.State==System.Data.ConnectionState.Closed) {
                sqlConnection.Open();

            }
        }

        public void closeconnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();

            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
