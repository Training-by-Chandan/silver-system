using Microsoft.EntityFrameworkCore;
using Silver.Web.Data;
using Silver.Web.Models;

namespace Silver.Web.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
        }

        public override IQueryable<Product> GetAll()
        {
            return dbset.Include(p => p.Category);
        }
    }
}