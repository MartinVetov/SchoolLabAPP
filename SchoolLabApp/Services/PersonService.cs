using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using System;

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
            try
            {
                _logger.Info($"Adding person: {person?.Name}");

                if (person == null)
                {
                    _logger.Error("Person object is null.");
                    throw new Exception("Person is null");
                }

                if (string.IsNullOrWhiteSpace(person.Name))
                {
                    _logger.Warn("AddPerson failed: Name is required.");
                    throw new Exception("Name is required");
                }

                if (string.IsNullOrWhiteSpace(person.Type))
                {
                    _logger.Warn("AddPerson failed: Type is required.");
                    throw new Exception("Type is required");
                }

                await _personRepository.AddAsync(person);

                _logger.Info($"Person added successfully: {person.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            try
            {
                _logger.Info("Getting all persons");
                return await _personRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Person>();
            }
        }

        public async Task<IEnumerable<Person>> GetStudents()
        {
            try
            {
                _logger.Info("Getting all students");
                return await _personRepository.GetByTypeAsync("Student");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Person>();
            }
        }

        public async Task<IEnumerable<Person>> GetTeachers()
        {
            try
            {
                _logger.Info("Getting all teachers");
                return await _personRepository.GetByTypeAsync("Teacher");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Person>();
            }
        }

        public async Task UpdatePerson(Person person)
        {
            try
            {
                _logger.Info($"Updating person Id={person.Id}");

                var existingPerson = await _personRepository.GetByIdAsync(person.Id);

                if (existingPerson == null)
                {
                    _logger.Error($"Person not found: {person.Id}");
                    throw new Exception("Person not found");
                }

                await _personRepository.UpdateAsync(person);

                _logger.Info($"Person updated successfully: {person.Id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task DeletePerson(int id)
        {
            try
            {
                _logger.Info($"Deleting person Id={id}");

                var existingPerson = await _personRepository.GetByIdAsync(id);

                if (existingPerson == null)
                {
                    _logger.Error($"Person not found: {id}");
                    throw new Exception("Person not found");
                }

                await _personRepository.DeleteAsync(id);

                _logger.Info($"Person deleted successfully: {id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}