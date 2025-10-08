using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categoriesLists;

        public CategoryRepository()
        {
            categoriesLists =
            [
                new Category(1, "Groente"),
                new Category(2, "Bakkerij"),
                new Category(3, "Zuivel"),

            ];
        }

        public List<Category> GetAll()
        {
            return categoriesLists;
        }

        public Category Add(Category item)
        {
            throw new NotImplementedException();
        }

        public Category? Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public Category? Get(int id)
        {
            Category? category = categoriesLists.FirstOrDefault(c => c.Id == id);
            return category;
        }

        public Category? Update(Category item)
        {
            Category? categoryList = categoriesLists.FirstOrDefault(c => c.Id == item.Id);
            categoryList = item;
            return categoryList;
        }
    }
}


