using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase{
    public List<Author> authors = new List<Author>(); 

    [HttpGet]
    public async Task<ActionResult<List<Author>>> get(){
        return Ok(authors);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<Author>>> get([FromRoute] int id){
        Author author = new Author();
        author.birthDate = DateTime.Now;
        author.name = "George R.R. Martin";
        author.profission = "Writer";
        author.id = 0;
        author.authorDescription = "George R.R. Martin is the author of the famous novel series Game of Thrones.";
        author.street = "Street";
        author.city = "Londom";
        author.state = "United Kingdom";

        return Ok(author);
    }

    [HttpPost]
    public async Task<ActionResult<Author>> create([FromBody] Author author){
        return Ok(author);
    } 

    [HttpPut]
    public async Task<ActionResult<Author>> update([FromRoute] int id, [FromBody] Author author){
        return Ok(author);
    }

    [HttpDelete]
    public async Task<ActionResult<Author>> delete([FromRoute] int id){
        var author = authors.Find(author => {return author.id == id;});
        return Ok(author);
    }
}