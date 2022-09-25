using AutoMapper;
using Silver.Web.Models;
using Silver.Web.Repositories;
using Silver.Web.ViewModels;

namespace Silver.Web.Services
{
    public interface IProductService
    {
        (bool, string) Create(ProductViewModel model);

        List<ProductViewModel> GetAll();

        ProductViewModel GetProductbyId(int id);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public List<ProductViewModel> GetAll()
        {
            var data = productRepository.GetAll();
            var ret = mapper.Map<List<Product>, List<ProductViewModel>>(data.ToList());
            return ret;
        }

        public (bool, string) Create(ProductViewModel model)
        {
            try
            {
                var product = mapper.Map<ProductViewModel, Product>(model);

                return productRepository.Create(product);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public ProductViewModel GetProductbyId(int id)
        {
            var data = productRepository.GetById(id);
            var ret = mapper.Map<Product, ProductViewModel>(data);
            return ret;
        }
    }
}