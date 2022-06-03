using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase{
    public List<Category> categories = new List<Category>();

    [HttpGet]
    public async Task<ActionResult<List<Category>>> get(){
        return Ok(categories);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Category>> get([FromRoute] int id){
        Category category = new Category();
        category.id = 0;
        category.name = "Fiction";
        category.description = "Fiction Books.";

        return Ok(category);
    }

    [HttpPost]
    public async Task<ActionResult<Category>> create([FromBody] Category category){
        return Ok(category);
    }

    [HttpPut]
    public async Task<ActionResult<Category>> update([FromRoute] int id, [FromBody] Category category){
        return Ok(category);
    }

    [HttpDelete]
    public async Task<ActionResult<Category>> delete([FromRoute] int id){
        var category = categories.Find(category => {return category.id == id;});
        return Ok(category);
    }
}