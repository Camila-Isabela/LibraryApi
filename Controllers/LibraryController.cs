using LibraryApi.Models;
using LibraryApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LibraryController(ILibraryService libraryService) :ControllerBase
{
    private readonly ILibraryService _libraryService = libraryService;

    [HttpGet]
    public async Task<IActionResult> GetAllBooks()
    {
        var books = await _libraryService.GetAllBooks();

        return Ok(books);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBookById(int id)
    {
        var book = await _libraryService.GetBookById(id);

        if(book == null)
        {
            return NotFound();
        }

        return Ok(book);
    }

    [HttpPost]
    public async Task<IActionResult> AddBook([FromBody] Book book)
    {
        if(book == null)
        {
            return BadRequest("Dados do livro são obrigatórios");
        }

        await _libraryService.AddBook(book);

        return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBook(int id, [FromBody] UpdateBookDto bookDto)
    {
        var updatedBook = await _libraryService.UpdateBook(id, bookDto);
        if(updatedBook == null)
            return NotFound();

        return Ok(updatedBook);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        var deleted = await _libraryService.DeleteBook(id);

        if(!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}