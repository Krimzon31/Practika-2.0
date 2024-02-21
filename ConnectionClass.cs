using System;
using System.Data.SqlClient;
using SD = System.Data;

namespace Practika
{
    internal class ConnectionClass
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=Krimzon; Initial Catalog=TehPod; Integrated Security=True");

        public ConnectionClass()
        {

        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
