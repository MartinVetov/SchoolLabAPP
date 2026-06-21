using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabAppTest.ServiceTests
{
    [TestFixture]
    public class RoleServiceTests
    {
        private RoleService _roleService;

        [SetUp]
        public void Setup() => _roleService = new RoleService(null!);

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
