using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabAppTest.ServiceTests
{
    [TestFixture]
    public class PersonServiceTests
    {
        private PersonService _personService;

        [SetUp]
        public void Setup() => _personService = new PersonService(null!);

        // --- ТЕСТОВЕ ЗА ДОБАВЯНЕ (ADD) ---

        [Test]
        public void AddPerson_NullPerson_DoesNotThrowException()
        {
            Assert.DoesNotThrowAsync(async () => await _personService.AddPerson(null!));
        }

        [Test]
        public void AddPerson_EmptyName_DoesNotThrowException()
        {
            var person = new Person { Name = "", Type = "Student" };
            Assert.DoesNotThrowAsync(async () => await _personService.AddPerson(person));
        }

        [Test]
        public void AddPerson_SpacesName_DoesNotThrowException()
        {
            var person = new Person { Name = "   ", Type = "Student" };
            Assert.DoesNotThrowAsync(async () => await _personService.AddPerson(person));
        }

        [Test]
        public void AddPerson_EmptyType_DoesNotThrowException()
        {
            var person = new Person { Name = "Георги", Type = "" };
            Assert.DoesNotThrowAsync(async () => await _personService.AddPerson(person));
        }

        [Test]
        public void AddPerson_SpacesType_DoesNotThrowException()
        {
            var person = new Person { Name = "Георги", Type = "   " };
            Assert.DoesNotThrowAsync(async () => await _personService.AddPerson(person));
        }

        // --- ТЕСТОВЕ ЗА UPDATE И DELETE ---

        [Test]
        public void UpdatePerson_NoRepository_DoesNotThrowException()
        {
            var person = new Person { Id = 1, Name = "Иван", Type = "Teacher" };
            Assert.DoesNotThrowAsync(async () => await _personService.UpdatePerson(person));
        }

        [Test]
        public void DeletePerson_NoRepository_DoesNotThrowException()
        {
            Assert.DoesNotThrowAsync(async () => await _personService.DeletePerson(1));
        }

        // --- ТЕСТОВЕ ЗА ИЗВЛИЧАНЕ (GET) ---

        [Test]
        public async Task GetAllPersons_NoRepository_ReturnsEmptyList()
        {
            var result = await _personService.GetAllPersons();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetStudents_NoRepository_ReturnsEmptyList()
        {
            var result = await _personService.GetStudents();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetTeachers_NoRepository_ReturnsEmptyList()
        {
            var result = await _personService.GetTeachers();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        }
    }
}
