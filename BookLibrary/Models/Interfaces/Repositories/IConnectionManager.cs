using System.Data.SqlClient;

namespace BookLibrary.Models.Interfaces.Repositories
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }
}
