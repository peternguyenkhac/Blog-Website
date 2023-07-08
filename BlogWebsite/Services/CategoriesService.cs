using BlogWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebsite.Services
{
    public class CategoriesService
    {
        private readonly BLOGDBContext _dbContext;
        public CategoriesService(BLOGDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> GetCategories()
        {
            var categories = _dbContext.Categories.ToList();
            return categories;
        }

        public Category DetailsCategory(int id)
        {
            var category = _dbContext.Categories.Single(c => c.Id == id);
            return category;
        }

        public void CreateCategory(Category category)
        {
            _dbContext.Add(category);
            _dbContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _dbContext.Update(category);
            _dbContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            _dbContext.Remove(new Category { Id = id });
            _dbContext.SaveChanges();
        }

        public int GetCategoryId(string name)
        {
            var category = _dbContext.Categories.Single(c => c.CategoryName.Replace(" ", "-") == name);
            return category.Id;
        }
    }
}
