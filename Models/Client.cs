namespace LibraryAPI.Models;

public class Client{
    public int id  {get; set; }
    public String name { get; set; }

    public DateTime birthDate { get; set; }

    public String street { get; set; }

    public int streetNumber { get; set; }

    public String city { get; set; }

    public String state { get; set; }
}