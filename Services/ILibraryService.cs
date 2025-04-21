using LibraryApi.Models;

namespace LibraryApi.Services;

public interface ILibraryService
{
    Task<IEnumerable<Book>> GetAllBooks();
    Task<Book?> GetBookById(int id);
    Task AddBook(Book book);
    Task<Book?> UpdateBook(Book book);
    Task<bool> DeleteBook(int id);
}