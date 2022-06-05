namespace LibraryAPI.Models;

public class Category{
    public int id { get; set; }

    public String name { get; set; }

    public String description { get; set; }

    public List<Book> books { get; set; }
}