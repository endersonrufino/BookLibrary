using BookLibrary.Models.Interfaces.Repositories;
using System.Data.SqlClient;

namespace BookLibrary.Models.Contexts
{
    public class ConnectionManager : IConnectionManager
    {
        private readonly string _connectionName = "Library";
        private readonly SqlConnection connection;

        public ConnectionManager(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString(_connectionName);

            if (connection == null)
                connection = new SqlConnection(connectionString);

        }
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
