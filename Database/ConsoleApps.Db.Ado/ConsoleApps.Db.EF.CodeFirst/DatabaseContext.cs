using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApps.Db.EF.CodeFirst
{
    //this class represents the database 
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PT71T7O\\SQLBHAGAT;Initial Catalog=Silver.Console.Db.EF.CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Class { get; set; }
    }

    public class Student
    {
        [Key]
        public int StudentNumber { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
        public int? ClassId { get; set; }
        
        [ForeignKey("ClassId")]
        public virtual Class? Class { get; set; }
    }

    public class Class
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
    }
}