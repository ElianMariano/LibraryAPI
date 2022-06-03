namespace LibraryAPI.Models;

public class Rent {
    public int id  {get; set; }
    public DateTime start { get; set; }

    public DateTime end { get; set; }

    public Book rentBook { get; set; }

    public Client client { get; set; }
}