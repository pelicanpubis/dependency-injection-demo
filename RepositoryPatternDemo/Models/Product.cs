using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternDemo.Models
{
    public class Product
    {
        [Key]
        //detta blir en identity column
        public int Id { get; set; }

        //sätter title så att den inte kan vara null
        public string Title { get; set; } = null!;

        public string? Category { get; set; }

        public decimal Price { get; set; }
    }
}
