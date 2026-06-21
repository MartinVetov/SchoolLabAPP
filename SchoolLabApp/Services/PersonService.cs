using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Services
{
    public class PersonService
    {
        private readonly PersonRepository _personRepository;
        private readonly Logger.Logger _logger;

        public PersonService(PersonRepository personRepository, Logger.Logger logger)
        {
            _personRepository = personRepository;
            _logger = logger;
        }

        public async Task AddPerson(Person person)
        {
            _logger.Info($"Adding person: {person?.Name}");

            if (person == null)
            {
                _logger.Error("Person object is null.");
                throw new ArgumentNullException(nameof(person), "Person is null");
            }

            if (string.IsNullOrWhiteSpace(person.Name))
            {
                _logger.Warn("AddPerson failed: Name is required.");
                throw new ArgumentException("Name is required");
            }

            if (string.IsNullOrWhiteSpace(person.Type))
            {
                _logger.Warn("AddPerson failed: Type is required.");
                throw new ArgumentException("Type is required");
            }

            await _personRepository.AddAsync(person);

            _logger.Info($"Person added successfully: {person.Name}");
        }

        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            _logger.Info("Getting all persons");
            return await _personRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Person>> GetStudents()
        {
            _logger.Info("Getting all students");
            return await _personRepository.GetByTypeAsync("Student");
        }

        public async Task<IEnumerable<Person>> GetTeachers()
        {
            _logger.Info("Getting all teachers");
            return await _personRepository.GetByTypeAsync("Teacher");
        }

        public async Task UpdatePerson(Person person)
        {
            _logger.Info($"Updating person Id={person?.Id}");

            if (person == null)
            {
                _logger.Error("Person object is null.");
                throw new ArgumentNullException(nameof(person), "Person is null");
            }

            var existingPerson = await _personRepository.GetByIdAsync(person.Id);

            if (existingPerson == null)
            {
                _logger.Error($"Person not found: {person.Id}");
                throw new InvalidOperationException("Person not found");
            }

            await _personRepository.UpdateAsync(person);

            _logger.Info($"Person updated successfully: {person.Id}");
        }

        public async Task DeletePerson(int id)
        {
            _logger.Info($"Deleting person Id={id}");

            var existingPerson = await _personRepository.GetByIdAsync(id);

            if (existingPerson == null)
            {
                _logger.Error($"Person not found: {id}");
                throw new InvalidOperationException("Person not found");
            }

            await _personRepository.DeleteAsync(id);

            _logger.Info($"Person deleted successfully: {id}");
        }
    }
}