using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Services;

namespace SchoolLabAppTest.ServiceTests
{
    [TestFixture]
    public class CategoryServiceTests
    {
        private CategoryService _categoryService;

        [SetUp]
        public void Setup()
        {
            _categoryService = new CategoryService(null!);
        }

        [Test]
        public void AddCategory_WithEmptyName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _categoryService.AddCategory(""));
            Assert.That(ex.Message, Is.EqualTo("Name is required"));
        }

        [Test]
        public void AddCategory_WithWhiteSpace_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _categoryService.AddCategory(" "));
            Assert.That(ex.Message, Is.EqualTo("Name is required"));
        }
    }
}
