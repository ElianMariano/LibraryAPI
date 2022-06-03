using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RentController : ControllerBase {
    public List<Rent> rents = new List<Rent>();

    [HttpGet]
    public async Task<ActionResult<List<Rent>>> get(){
        return Ok(rents);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Rent>> get([FromRoute] int id){
        return Ok(rents);
    }

    [HttpPost]
    public async Task<ActionResult<Rent>> create([FromBody] Rent rent){
        return Ok(rent);
    }

    [HttpPut]
    public async Task<ActionResult<Rent>> update([FromRoute] int id, [FromBody] Rent rent){
        return Ok(rent);
    }

    [HttpDelete]
    public async Task<ActionResult<Rent>> delete([FromRoute] int id, [FromBody] Rent rent){
        return Ok(rent);
    }
}