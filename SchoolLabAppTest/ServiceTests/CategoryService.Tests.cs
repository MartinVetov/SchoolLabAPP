
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Services;

namespace SchoolLabApp.Tests.CategoryServiceTests
{
    [TestFixture]
    public class CategoryServiceTests
    {
        private CategoryService _categoryService;

        [SetUp]
        public void Setup()
        {
            var logger = new Logger.Logger();

            _categoryService = new CategoryService(null!, logger);
        }

        [Test]
        public void AddCategory_NullName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _categoryService.AddCategory(null!));

            Assert.That(ex.Message, Is.EqualTo("Name is required"));
        }

        [Test]
        public void AddCategory_EmptyName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _categoryService.AddCategory(""));

            Assert.That(ex.Message, Is.EqualTo("Name is required"));
        }

        [Test]
        public void AddCategory_SpacesName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _categoryService.AddCategory("   "));

            Assert.That(ex.Message, Is.EqualTo("Name is required"));
        }
    }
}