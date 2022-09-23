using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Silver.Web.Models;
using Silver.Web.Repositories;
using Silver.Web.ViewModels;

namespace Silver.Web.Services
{
    public interface ICategoryService
    {
        (bool, string) Create(CategoryViewModel model);

        List<CategoryViewModel> GetAll();

        IEnumerable<SelectListItem> GetDropDown();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(
            ICategoryRepository categoryRepository,
            IMapper mapper
            )
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public List<CategoryViewModel> GetAll()
        {
            var data = categoryRepository.GetAll();
            var ret = mapper.Map<List<Category>, List<CategoryViewModel>>(data.ToList());
            return ret;
        }

        public (bool, string) Create(CategoryViewModel model)
        {
            try
            {
                var category = mapper.Map<CategoryViewModel, Category>(model);
                category.CreatedDate = DateTime.Now;

                return categoryRepository.Create(category);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public IEnumerable<SelectListItem> GetDropDown()
        {
            var data = categoryRepository.GetAll();
            var ret = mapper.Map<List<Category>, List<SelectListItem>>(data.ToList());
            return ret;
        }
    }
}