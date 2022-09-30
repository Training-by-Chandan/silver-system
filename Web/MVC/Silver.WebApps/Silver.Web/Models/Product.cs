using System.ComponentModel.DataAnnotations.Schema;

namespace Silver.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Units Units { get; set; }
        public double Quantity { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public string? FilePath { get; set; }
    }
}