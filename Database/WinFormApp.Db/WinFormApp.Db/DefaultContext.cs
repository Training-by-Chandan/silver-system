using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WinFormApp.Db.Models;

namespace WinFormApp.Db
{
    public class DefaultContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Program.connectionString);
        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
    }
}