using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Silver.Web.Models;

namespace Silver.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? ParentId { get; set; }

        public string ParentName { get; set; }
    }
}