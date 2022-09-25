using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Silver.Web.Models;
using Silver.Web.ViewModels;

namespace Silver.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>().AfterMap((src, dest) =>
            {
                dest.ParentName = src.Parent == null ? "" : src.Parent.Name;
            });

            CreateMap<CategoryViewModel, Category>();

            CreateMap<Category, SelectListItem>().AfterMap((src, dest) =>
            {
                dest.Value = src.Id.ToString();
                dest.Text = src.Name;
            });

            CreateMap<Product, ProductViewModel>().AfterMap((src, dest) =>
            {
                dest.CategoryName = src.Category == null ? "" : src.Category.Name;
            });
            CreateMap<ProductViewModel, Product>();
        }
    }
}