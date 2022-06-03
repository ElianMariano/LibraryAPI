namespace LibraryAPI.Models;

public class Book{
    public int id  {get; set; }
    public DateTime launchDate { get; set; }

    public Author bookAuthor { get; set; }

    public String title { get; set; }

    public String description { get; set; }
}