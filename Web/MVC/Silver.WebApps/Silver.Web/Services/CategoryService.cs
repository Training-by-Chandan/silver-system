using Silver.Web.Repositories;
using Silver.Web.ViewModels;

namespace Silver.Web.Services
{
    public interface ICategoryService
    {
        IQueryable<CategoryViewModel> GetAll();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IQueryable<CategoryViewModel> GetAll()
        {
            return categoryRepository.GetAll().Select(p => new CategoryViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                ParentId = p.ParentId,
                ParentName = p.Parent == null ? "" : p.Parent.Name
            });
        }
    }
}