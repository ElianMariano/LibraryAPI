using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase {
    private List<Client> clients = new List<Client>();

    private readonly ApplicationDbContext _context;

    public ClientController(ApplicationDbContext context){
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Client>>> get(){
        return Ok(clients);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<Client>>> get([FromRoute] int id){
        // Client client;
        // using (ApplicationDbContext context = new ApplicationDbContext()){
        //     client = context.Clients.Where(client => client.id == id).First();
        // }
        return Ok(clients);
    }

    [HttpPost]
    public async Task<ActionResult<Client>> create([FromBody] Client client){
        // using (ApplicationDbContext context = new ApplicationDbContext()){
        //     context.Add(client);
        // }
        return Ok(clients);
    }

    [HttpPut]
    public async Task<ActionResult<Client>> update([FromRoute] int id, [FromBody] Client client){
        return Ok(client);
    }

    [HttpDelete]
    public async Task<ActionResult<Client>> delete(int id){
        var client = clients.Find(client => {return client.id == id;});
        return Ok(client);
    }
}