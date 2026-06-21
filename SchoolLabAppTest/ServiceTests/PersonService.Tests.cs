using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Models;
using SchoolLabApp.Services;

namespace SchoolLabApp.Tests
{
    [TestFixture]
    public class PersonServiceTests
    {
        private PersonService _personService;

        [SetUp]
        public void Setup()
        {
            var logger = new Logger.Logger();

            _personService = new PersonService(null!, logger);
        }

        [Test]
        public void AddPerson_NullPerson_ThrowsArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () =>
                await _personService.AddPerson(null!));
        }

        [Test]
        public void AddPerson_EmptyName_ThrowsArgumentException()
        {
            var person = new Person { Name = "", Type = "Student" };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _personService.AddPerson(person));

            Assert.That(ex.Message, Is.EqualTo("Name is required"));
        }

        [Test]
        public void AddPerson_SpacesName_ThrowsArgumentException()
        {
            var person = new Person { Name = "   ", Type = "Student" };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _personService.AddPerson(person));

            Assert.That(ex.Message, Is.EqualTo("Name is required"));
        }

        [Test]
        public void AddPerson_EmptyType_ThrowsArgumentException()
        {
            var person = new Person { Name = "Иван Иванов", Type = "" };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _personService.AddPerson(person));

            Assert.That(ex.Message, Is.EqualTo("Type is required"));
        }

        [Test]
        public void AddPerson_SpacesType_ThrowsArgumentException()
        {
            var person = new Person { Name = "Иван Иванов", Type = "   " };

            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _personService.AddPerson(person));

            Assert.That(ex.Message, Is.EqualTo("Type is required"));
        }

        [Test]
        public void UpdatePerson_NullPerson_ThrowsArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () =>
                await _personService.UpdatePerson(null!));
        }

    }
}