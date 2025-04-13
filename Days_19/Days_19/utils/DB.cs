
using Microsoft.Data.SqlClient;

namespace Days_19.Utils;
    public class DB
    {
     static string _connectionString = "Server=.;Database=contacts;Integrated Security=True;TrustServerCertificate=True;";
        SqlConnection _connection = new SqlConnection(_connectionString);

        public SqlConnection GetConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                    Console.WriteLine("Connection opened.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return _connection;
        }

        public void CloseConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
