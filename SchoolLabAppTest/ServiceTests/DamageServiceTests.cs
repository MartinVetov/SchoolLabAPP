using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using SchoolLabApp.Services;

namespace SchoolLabAppTest.ServiceTests
{
    [TestFixture]
    public class DamageServiceTests
    {
        private DamageService _damageService;

        [SetUp]
        public void Setup()
        {     
            _damageService = new DamageService(null!);
    
        }

        [Test]
        public void AddDamage_WithEmptyDescription_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _damageService.AddDamage(1, ""));
            Assert.That(ex.Message, Is.EqualTo("Description cannot be empty."));
        }

        [Test]
        public void AddDamage_WithWhiteSpaceDescription_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _damageService.AddDamage(1, "   "));
            Assert.That(ex.Message, Is.EqualTo("Description cannot be empty."));
        }

        [Test]
        public void AddDamage_WithNullDescription_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _damageService.AddDamage(1, null!));
            Assert.That(ex.Message, Is.EqualTo("Description cannot be empty."));
        }
    }
}

