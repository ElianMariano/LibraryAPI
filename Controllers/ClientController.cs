using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase {
    private List<Client> clients = new List<Client>();


    [HttpGet]
    public async Task<ActionResult<List<Client>>> get(){
        return Ok(clients);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<Client>>> get([FromRoute] int id){
        return Ok(clients);
    }

    [HttpPost]
    public async Task<ActionResult<Client>> create([FromBody] Client client){
        clients.Add(client);
        return Ok(client);
    }

    [HttpPut]
    public async Task<ActionResult<Client>> update([FromRoute] int id,[FromBody] Client client){
        return Ok(client);
    }

    [HttpDelete]
    public async Task<ActionResult<Client>> delete(int id){
        var client = clients.Find(client => {return client.id == id;});
        return Ok(client);
    }
}