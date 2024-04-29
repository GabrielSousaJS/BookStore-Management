using BookStoreManagement.Communication.Requests;
using BookStoreManagement.Entities;

namespace BookStoreManagement.Database;

public class BookCatalog
{
    public static List<Book> Books { get; set; } = new List<Book>();

    public static void AddBook(string id, RequestRegisterBook request)
    {
        Books.Add(new Book()
        {
            Id = id,
            Title = request.Title,
            Author = request.Author,
            Genre = request.Genre,
            Price = request.Price,
            QuantityStock = request.QuantityStock
        });
    }

    public static List<Book> AllBooks()
    {
        return Books.OrderBy(book => book.Title).ToList();
    }

    public static Book Update(string id, RequestUpdateBook request)
    {
        var book = Books.FirstOrDefault(book => id == book.Id);

        if (book == null)
        {
            return book;
        }

        book.Title = request.Title;
        book.Author = request.Author;
        book.Genre = request.Genre;
        book.Price = request.Price;
        book.QuantityStock = request.QuantityStock;

        return book;
    }

    public static void Delete(string id)
    {
        var book = Books.FirstOrDefault(book => id == book.Id);

        if (book != null)
        {
            Books.Remove(book);
        }
    }
}
