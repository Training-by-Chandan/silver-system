using Microsoft.EntityFrameworkCore;
using WinFormApp.Db.Models;

namespace WinFormApp.Db
{
    public class DefaultContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PT71T7O\\SQLBHAGAT;Initial Catalog=Silver.Winform.CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<UserInfo> UserInfos { get; set; }
    }
}