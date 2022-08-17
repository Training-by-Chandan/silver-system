using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace WinFormApp.Db.Models
{
    [Table("Inventory")]
    public class Inventory
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public double Price { get; set; }
        public Units Units { get; set; }
        public double Quantity { get; set; }
    }
}