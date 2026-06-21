using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Models;
using SchoolLabApp.Services;

namespace SchoolLabApp.Tests.UserServiceTests
{
    [TestFixture]
    public class UserServiceTests
    {
        private UserService _userService;

        [SetUp]
        public void Setup()
        {
            var logger = new Logger.Logger();

            _userService = new UserService(null!, logger);
        }

        [Test]
        public void Register_NullUser_ThrowsArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () =>
                await _userService.Register(null!));
        }

        [Test]
        public void Register_EmptyUsername_ThrowsArgumentException()
        {
            var user = new User { Username = "", Password = "password123", RoleId = 1 };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Register(user));

            Assert.That(ex.Message, Is.EqualTo("Username is required."));
        }

        [Test]
        public void Register_SpacesUsername_ThrowsArgumentException()
        {
            var user = new User { Username = "   ", Password = "password123", RoleId = 1 };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Register(user));

            Assert.That(ex.Message, Is.EqualTo("Username is required."));
        }

        [Test]
        public void Register_EmptyPassword_ThrowsArgumentException()
        {
            var user = new User { Username = "admin", Password = "", RoleId = 1 };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Register(user));

            Assert.That(ex.Message, Is.EqualTo("Password is required."));
        }

        [Test]
        public void Register_SpacesPassword_ThrowsArgumentException()
        {
            var user = new User { Username = "admin", Password = "   ", RoleId = 1 };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Register(user));

            Assert.That(ex.Message, Is.EqualTo("Password is required."));
        }

        [Test]
        public void Register_InvalidRoleId_ThrowsArgumentException()
        {
            var user = new User { Username = "admin", Password = "password123", RoleId = 0 };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Register(user));

            Assert.That(ex.Message, Is.EqualTo("A valid role must be selected."));
        }

        [Test]
        public void Login_EmptyUsername_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Login("", "password123"));

            Assert.That(ex.Message, Is.EqualTo("Username is required."));
        }

        [Test]
        public void Login_SpacesUsername_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Login("   ", "password123"));

            Assert.That(ex.Message, Is.EqualTo("Username is required."));
        }

        [Test]
        public void Login_EmptyPassword_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Login("admin", ""));

            Assert.That(ex.Message, Is.EqualTo("Password is required."));
        }

        [Test]
        public void Login_SpacesPassword_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _userService.Login("admin", "   "));

            Assert.That(ex.Message, Is.EqualTo("Password is required."));
        }

        [Test]
        public void GetCurrentUserId_NoUserLoggedIn_ThrowsInvalidOperationException()
        {
            var ex = Assert.Throws<InvalidOperationException>(() =>
                _userService.GetCurrentUserId());

            Assert.That(ex.Message, Is.EqualTo("No user is logged in."));
        }
    }
}