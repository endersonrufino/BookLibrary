using BookLibrary.Models.Enums;

namespace BookLibrary.Models.Repositories
{
    public class SqlManager
    {
        public static string GetQuery(TSql tSql)
        {
            string query = "";

            switch (tSql)
            {
                case TSql.ADD_BOOK:
                    query = @"INSERT INTO Book (Id, Name, Author, PublishingCompany) 
                              VALUES (@id, @name, @author, @publishingCompany)"
                    ;
                    break;
                case TSql.LIST_BOOK:
                    query = @"SELECT * FROM BOOK";
                    break;
                case TSql.SEARCH_BOOK:
                    query = @"SELECT * FROM Book WHERE Id = @id";
                    break;
                case TSql.UPDATE_BOOK:
                    query = @"UPDATE Book
                              SET Name = @name, Author = @author, PublishingCompany = @publishingCompany
                              WHERE Id = @id"
                    ;
                    break;
                case TSql.DELETE_BOOK:
                    query = @"DELETE Book WHERE Id = @id";
                    break;
                default:
                    break;
            }

            return query;
        }
    }
}