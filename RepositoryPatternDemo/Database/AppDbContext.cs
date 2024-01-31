using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Database
{
    //måste ärva från Dbcontext för att det ska fungera
    
    //vi har denna så att vi kan använda vår connectionstring
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }    
    }
}
