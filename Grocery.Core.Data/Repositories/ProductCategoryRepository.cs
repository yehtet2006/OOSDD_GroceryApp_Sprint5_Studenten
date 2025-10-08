using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly List<ProductCategory> productCategoriesList;
        
        public ProductCategoryRepository()
        {
            productCategoriesList =
            [
                new ProductCategory(1, 1, 1),
                new ProductCategory(2, 2, 1),
                new ProductCategory(3, 3, 1),
            ];
        }
        public List<ProductCategory> GetAll()
        {
            return productCategoriesList;
        }

        public List<ProductCategory> GetAllOnCategoryId(int id)
        {
            return productCategoriesList.Where(p => p.CategoryId == id).ToList();
        }
        
        public ProductCategory? Add(ProductCategory item)
        {
            int newId = productCategoriesList.Max(g => g.Id) + 1;
            item.Id = newId;
            productCategoriesList.Add(item);
            return Get(item.Id); 
        }

        public ProductCategory? Delete(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Get(int id)
        {
            return productCategoriesList.FirstOrDefault(p => p.Id == id);
        }

        public ProductCategory? Update(ProductCategory item)
        {
            ProductCategory? listItem = productCategoriesList.FirstOrDefault(i => i.Id == item.Id);
            listItem = item;
            return listItem;
        }
    }
}

