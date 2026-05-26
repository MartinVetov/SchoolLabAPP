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

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task AddCategory(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentException("Name is required");
            }
            Category category = new Category()
            {
                Name = categoryName
            };
            await _categoryRepository.AddAsync(category);
        }

        public async Task UpdateCategory(Category category)
        {
            var exists = await _categoryRepository.ExistsAsync(category.Id);
            if (!exists)
            {
                throw new InvalidOperationException("Category not found.");
            }
            await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeleteCategory(int id)
        {
            var categories = await _categoryRepository.GetByIdAsync(id);
            if (categories == null)
            {
                throw new Exception("Category not found");
            }
            await _categoryRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _categoryRepository.GetAllAsync();
        }
    }
}
