using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly List<ProductCategory> productCategoriesList;
        
        public ProductCategoryRepository()
        {
            productCategoriesList = new List<ProductCategory>
            {
               new ProductCategory(1, "Groente", 1, 1),
               new ProductCategory(2, "Groente", 2, 1),
               new ProductCategory(3, "Groente", 3, 1),
            };
        }
        public List<ProductCategory> GetAll()
        {
            return productCategoriesList;
        }

        public ProductCategory? Add(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Delete(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Get(int id)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Update(ProductCategory item)
        {
            throw new NotImplementedException();
        }
    }
}

