using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Models;
using SchoolLabApp.Services;

namespace SchoolLabApp.Tests.RoleServiceTests
{
    [TestFixture]
    public class RoleServiceTests
    {
        private RoleService _roleService;

        [SetUp]
        public void Setup()
        {
            var logger = new Logger.Logger();

            _roleService = new RoleService(null!, logger);
        }

        [Test]
        public void AddRole_NullName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _roleService.AddRole(null!));

            Assert.That(ex.Message, Is.EqualTo("Role name cannot be empty."));
        }

        [Test]
        public void AddRole_EmptyName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _roleService.AddRole(""));

            Assert.That(ex.Message, Is.EqualTo("Role name cannot be empty."));
        }

        [Test]
        public void AddRole_SpacesName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _roleService.AddRole("   "));

            Assert.That(ex.Message, Is.EqualTo("Role name cannot be empty."));
        }
    }
}
