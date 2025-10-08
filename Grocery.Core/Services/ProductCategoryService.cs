using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductRepository _productRepository;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository,
            IProductRepository productRepository)
        {
            _productCategoryRepository = productCategoryRepository;
            _productRepository = productRepository;
        }
        
        public List<ProductCategory> GetAll()
        {
            List<ProductCategory> productCategories = _productCategoryRepository.GetAll();
            FillService(productCategories);
            return productCategories;
        }

        public List<ProductCategory> GetAllOnCategoryId(int categoryId)
        {
            List<ProductCategory> productCategories = _productCategoryRepository.GetAll().Where(p => p.CategoryId == categoryId).ToList();
            FillService(productCategories);
            return productCategories;
        }

        public ProductCategory Add(ProductCategory item)
        {
            return _productCategoryRepository.Add(item);
        }

        public ProductCategory? Delete(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Get(int id)
        {
            return _productCategoryRepository.Get(id);
        }

        public ProductCategory? Update(ProductCategory item)
        {
            return _productCategoryRepository.Update(item);
        }
        
        // Fills the Product property of each ProductCategory in the list
        private void FillService(List<ProductCategory> productCategories)
        {
            foreach (ProductCategory p in productCategories)
            {
                p.Product = _productRepository.Get(p.ProductId) ?? new(0, "None", 0);
            }
        }
    }
}

