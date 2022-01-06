using BookLibrary.Models.Interfaces.Contexts;
using BookLibrary.Models.Interfaces.Repositories;
using BookLibrary.Models.ViewModels;
using System.Data.SqlClient;
using BookLibrary.Models.Repositories;
using BookLibrary.Models.Enums;
using System.Data;

namespace BookLibrary.Models.Contexts
{
    public class ContextDataSqlServer : IContextData
    {
        private readonly SqlConnection _connection;

        public ContextDataSqlServer(IConnectionManager connectionManager)
        {
            _connection = connectionManager.GetConnection();
        }

        public void AddBook(BookViewModel book)
        {
            try
            {
                _connection.Open();

                string query = SqlManager.GetQuery(TSql.ADD_BOOK);

                SqlCommand command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = book.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = book.Name;
                command.Parameters.Add("@author", SqlDbType.VarChar).Value = book.Author;
                command.Parameters.Add("@publishingCompany", SqlDbType.VarChar).Value = book.PublishingCompany;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public List<BookViewModel> GetAll()
        {
            List<BookViewModel> books = new List<BookViewModel>();

            try
            {               
                string query = SqlManager.GetQuery(TSql.LIST_BOOK);

                SqlCommand command = new SqlCommand(query, _connection);

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);

                var rows = dataSet.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunm = item.ItemArray;

                    var id = Convert.ToInt32(colunm[0]);
                    var name = Convert.ToString(colunm[1]);
                    var author = Convert.ToString(colunm[2]);
                    var publishingCompany = Convert.ToString(colunm[3]);

                    BookViewModel book = new BookViewModel(id, name, author, publishingCompany);
                    books.Add(book);
                }

                adapter = null;
                dataSet = null;

                return books;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public void DeleteBook(BookViewModel book)
        {
            try
            {
                _connection.Open();

                string query = SqlManager.GetQuery(TSql.DELETE_BOOK);

                SqlCommand command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = book.Id;                

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public BookViewModel GetBook(int id)
        {
            BookViewModel book = null;

            try
            {
                string query = SqlManager.GetQuery(TSql.SEARCH_BOOK);

                SqlCommand command = new SqlCommand(query, _connection);

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);

                var rows = dataSet.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunm = item.ItemArray;
                    
                    var name = Convert.ToString(colunm[1]);
                    var author = Convert.ToString(colunm[2]);
                    var publishingCompany = Convert.ToString(colunm[3]);

                    book = new BookViewModel(id, name, author, publishingCompany);                    
                }

                adapter = null;
                dataSet = null;

                return book;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateBook(BookViewModel book)
        {
            try
            {
                _connection.Open();

                string query = SqlManager.GetQuery(TSql.UPDATE_BOOK);

                SqlCommand command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = book.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = book.Name;
                command.Parameters.Add("@author", SqlDbType.VarChar).Value = book.Author;
                command.Parameters.Add("@publishingCompany", SqlDbType.VarChar).Value = book.PublishingCompany;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}
