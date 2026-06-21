using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Services;

namespace SchoolLabApp.Tests.DamageServiceTests
{
    [TestFixture]
    public class DamageServiceTests
    {
        private DamageService _damageService;

        [SetUp]
        public void Setup()
        {
            var logger = new Logger.Logger();

            _damageService = new DamageService(null!, logger);
        }

        [Test]
        public void AddDamage_NullDescription_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _damageService.AddDamage(1, null!));

            Assert.That(ex.Message, Is.EqualTo("Description cannot be empty."));
        }

        [Test]
        public void AddDamage_EmptyDescription_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _damageService.AddDamage(1, ""));

            Assert.That(ex.Message, Is.EqualTo("Description cannot be empty."));
        }

        [Test]
        public void AddDamage_SpacesDescription_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _damageService.AddDamage(1, "   "));

            Assert.That(ex.Message, Is.EqualTo("Description cannot be empty."));
        }
    }
}

