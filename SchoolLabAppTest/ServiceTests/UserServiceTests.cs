using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabAppTest.ServiceTests
{
    [TestFixture]
    public class UserServiceTests
    {
        private UserService _userService;

        [SetUp]
        public void Setup() => _userService = new UserService(null!);

        [Test]
        public void Register_NullUser_ThrowsArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () => await _userService.Register(null!));
        }

        [Test]
        public void Register_EmptyUsername_ThrowsArgumentException()
        {
            var user = new User { Username = "", Password = "123", RoleId = 1 };
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _userService.Register(user));
            Assert.That(ex.Message, Is.EqualTo("Username is required."));
        }

        [Test]
        public void Register_EmptyPassword_ThrowsArgumentException()
        {
            var user = new User { Username = "ivan", Password = "", RoleId = 1 };
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _userService.Register(user));
            Assert.That(ex.Message, Is.EqualTo("Password is required."));
        }

        [Test]
        public void Register_InvalidRoleId_ThrowsArgumentException()
        {
            var user = new User { Username = "ivan", Password = "123", RoleId = 0 };
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _userService.Register(user));
            Assert.That(ex.Message, Is.EqualTo("A valid role must be selected."));
        }

        [Test]
        public void Login_EmptyUsername_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _userService.Login("", "123"));
            Assert.That(ex.Message, Is.EqualTo("Username is required."));
        }

        [Test]
        public void Login_EmptyPassword_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _userService.Login("ivan", ""));
            Assert.That(ex.Message, Is.EqualTo("Password is required."));
        }

    }
}
