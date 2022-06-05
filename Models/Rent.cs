namespace LibraryAPI.Models;

public class Rent {
    public int id  {get; set; }
    public DateTime start { get; set; }

    public DateTime end { get; set; }

    public int BookId { get; set; }
    public Book Book { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
}