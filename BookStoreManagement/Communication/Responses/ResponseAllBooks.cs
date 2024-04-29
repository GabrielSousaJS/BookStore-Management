using BookStoreManagement.Database;
using BookStoreManagement.Entities;

namespace BookStoreManagement.Communication.Responses;

public class ResponseAllBooks
{
    public List<Book> Books { get; set; } = BookCatalog.AllBooks();
}
