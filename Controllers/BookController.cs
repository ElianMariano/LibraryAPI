using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase{
    public List<Book> books = new List<Book>();

    private readonly ApplicationDbContext _context;

    public BookController(ApplicationDbContext context){
        _context = context;
    } 

    [HttpGet]
    public async Task<ActionResult<Book>> get(){
        return Ok(_context.Books.ToList());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> get([FromRoute] int id){
        // Returns an sample data
        Author author = new Author();
        author.birthDate = DateTime.Now;
        author.name = "George R.R. Martin";
        author.profission = "Writer";
        author.id = 0;
        author.description = "George R.R. Martin is the author of the famous novel series Game of Thrones.";

        Book book = new Book();
        book.title = "A Game Of Thrones";
        book.description = "The First book of the series Game Of Thrones.";
        book.launchDate = DateTime.Now;
        book.author = author;
        book.id = 0;
        return Ok(book);
    }

    [HttpPost]
    public async Task<ActionResult<Book>> create([FromBody] Book book){
        return Ok(book);
    }

    [HttpPut]
    public async Task<ActionResult<Book>> update([FromRoute] int id, [FromBody] Book book){
        return Ok(book);
    }

    [HttpDelete]
    public async Task<ActionResult<Book>> delete([FromRoute] int id){
        return Ok(books);
    }
}