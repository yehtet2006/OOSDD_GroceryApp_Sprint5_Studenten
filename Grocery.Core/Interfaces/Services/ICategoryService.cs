using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
        public List<Category> GetAllOnProductCategoryListId(int id);
        public Category Add(Category item);
        public Category? Delete(Category item);
        public Category? Get(int id);
        public Category? Update(Category item);
    }
}

