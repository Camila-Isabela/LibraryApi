using LibraryApi.Models;

namespace LibraryApi.Services;

public class LibraryService :ILibraryService
{
    private readonly List<Book> _books =
    [
        new Book { Id = 1, Title = "1984", Author = "George Orwell", Genre = "Dystopian", PublishedDate = new DateTime(1949, 6, 8), IsAvailable = true },
        new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", PublishedDate = new DateTime(1960, 7, 11), IsAvailable = true },
        new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", PublishedDate = new DateTime(1925, 4, 10), IsAvailable = false },
        new Book { Id = 4, Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Genre = "Fantasy", PublishedDate = new DateTime(1997, 6, 26), IsAvailable = true },
    ];


    public async Task<IEnumerable<Book>> GetAllBooks()
    {
        return await Task.FromResult(_books);
    }

    public async Task<Book?> GetBookById(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        return await Task.FromResult(book);
    }

    public async Task AddBook(Book book)
    {
        book.Id = _books.Max(b => b.Id) + 1;
        _books.Add(book);
        await Task.CompletedTask;
    }

    public async Task<Book?> UpdateBook(Book book)
    {
        var existingBook = _books.FirstOrDefault(b => b.Id == book.Id);

        if(existingBook == null)
        {
            return null;
        }

        existingBook.Title = book.Title;
        existingBook.Author = book.Author;
        existingBook.Genre = book.Genre;
        existingBook.PublishedDate = book.PublishedDate;
        existingBook.IsAvailable = book.IsAvailable;

        return await Task.FromResult(existingBook);
    }

    public async Task<bool> DeleteBook(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        if(book != null)
        {
            _books.Remove(book);
            return await Task.FromResult(true);
        }
        return await Task.FromResult(false);
    }

}