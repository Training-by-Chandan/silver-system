using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Silver.Web.Models;

namespace Silver.Web.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Units Units { get; set; }
        public double Quantity { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? FilePath { get; set; }
    }
}