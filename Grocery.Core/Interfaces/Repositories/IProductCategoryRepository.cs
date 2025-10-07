using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IProductCategoryRepository
    {
        public List<ProductCategory> GetAll(); // Get all product categories
        
        public ProductCategory? Add(ProductCategory item); // Add a new product category
        
        public ProductCategory? Delete(ProductCategory item); // Delete a product category
        
        public ProductCategory? Get(int id); // Get a product category by ID
        
        public ProductCategory? Update(ProductCategory item); // Update a product category
    }
}

    