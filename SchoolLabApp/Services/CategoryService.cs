using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly Logger.Logger _logger;

        public CategoryService(CategoryRepository categoryRepository, Logger.Logger logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        public async Task AddCategory(string categoryName)
        {
            _logger.Info($"Adding new category {categoryName}");

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                _logger.Error("Add category failed: empty name");
                throw new ArgumentException("Name is required");
            }

            Category category = new Category()
            {
                Name = categoryName
            };

            _logger.Info($"{categoryName} was added as category");

            await _categoryRepository.AddAsync(category);
        }

        public async Task UpdateCategory(Category category)
        {
            _logger.Info($"Updating category Id={category.Id}");

            var exists = await _categoryRepository.ExistsAsync(category.Id);

            if (!exists)
            {
                _logger.Error($"Category not found: {category.Id}");
                throw new InvalidOperationException("Category not found.");
            }

            _logger.Info($"Category updated successfully: {category.Id}");

            await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeleteCategory(int id)
        {
            _logger.Info($"Deleting category Id={id}");

            var categories = await _categoryRepository.GetByIdAsync(id);

            if (categories == null)
            {
                _logger.Error($"Category not found: {id}");
                throw new Exception("Category not found");
            }

            _logger.Info($"Category deleted successfully: {id}");

            await _categoryRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            _logger.Info("Getting all categories");
            return await _categoryRepository.GetAllAsync();
        }
    }
}
