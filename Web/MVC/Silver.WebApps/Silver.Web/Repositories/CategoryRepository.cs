using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Silver.Web.Data;
using Silver.Web.Models;

namespace Silver.Web.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
    }

    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}