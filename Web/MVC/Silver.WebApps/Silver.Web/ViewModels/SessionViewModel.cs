using Silver.Web.Models;

namespace Silver.Web.ViewModels
{
    public class SessionViewModel
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Units Unit { get; set; }
        public string? FilePath { get; set; }

        public double Total => Quantity * Price;
    }
}