using LibraryApi.Models;

namespace LibraryApi.Services;

public class LibraryService :ILibraryService
{
    private readonly List<Book> _books =
    [
        new Book { Id = 1, Title = "1984", Author = "George Orwell", Genre = "Dystopian", Price = 132, QuantityInStock = 324 },
        new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Price = 84, QuantityInStock = 148 },
        new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Price = 98, QuantityInStock = 235 },
        new Book { Id = 4, Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Genre = "Fantasy", Price = 345, QuantityInStock = 18 },
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

    public async Task<Book?> UpdateBook(int id, UpdateBookDto updateBookDto)
    {
        var existingBook = _books.FirstOrDefault(b => b.Id == id);

        if(existingBook == null)
            return null;

        if(updateBookDto.Title is not null)
            existingBook.Title = updateBookDto.Title;

        if(updateBookDto.Author is not null)
            existingBook.Author = updateBookDto.Author;

        if(updateBookDto.Genre is not null)
            existingBook.Genre = updateBookDto.Genre;

        if(updateBookDto.Price.HasValue)
            existingBook.Price = updateBookDto.Price.Value;

        if(updateBookDto.QuantityInStock.HasValue)
            existingBook.QuantityInStock = updateBookDto.QuantityInStock.Value;

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