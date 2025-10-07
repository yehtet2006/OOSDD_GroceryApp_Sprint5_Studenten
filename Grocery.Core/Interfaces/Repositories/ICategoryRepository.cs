using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll(); // Get all categories
        public Category Add(Category item); // Add a new category
        public Category? Delete(Category item); // Delete a category
        public Category? Get(int id); // Get a category by ID
        public Category? Update(Category item); // Update a category
    }
}

