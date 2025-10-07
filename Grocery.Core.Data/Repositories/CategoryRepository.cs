using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categoriesList;

        public CategoryRepository()
        {
            categoriesList =
            [
                new Category(1, "Groente"),
                new Category(2, "Fruit"),
                new Category(3, "Zuivel"),

            ];
        }

        public List<Category> GetAll()
        {
            return categoriesList;
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
            Category? category = categoriesList.FirstOrDefault(c => c.Id == id);
            return category;
        }

        public Category? Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}


