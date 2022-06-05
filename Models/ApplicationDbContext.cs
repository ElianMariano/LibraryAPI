using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models;
public class ApplicationDbContext : DbContext
{
    public string DbPath { get; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
        : base(contextOptions)
    {
    }


    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; } 
    public DbSet<Client> Clients { get; set; }
    public DbSet<Rent> Rents { get; set; }
}