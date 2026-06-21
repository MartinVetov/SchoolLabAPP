using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Services
{
    public class RoleService
    {
        private readonly RoleRepository _roleRepository;
        private readonly Logger.Logger _logger;

        public RoleService(RoleRepository roleRepository, Logger.Logger logger)
        {
            _roleRepository = roleRepository;
            _logger = logger;
        }

        public async Task AddRole(string name)
        {
            _logger.Info($"Adding role: {name}");

            if (string.IsNullOrWhiteSpace(name))
            {
                _logger.Warn("AddRole failed: empty name");
                throw new ArgumentException("Role name cannot be empty.");
            }

            var role = new Role { Name = name };
            await _roleRepository.AddAsync(role);

            _logger.Info($"Role added successfully: {name}");
        }

        public async Task UpdateRole(Role role)
        {
            _logger.Info($"Updating role Id={role.Id}");

            if (await _roleRepository.GetByIdAsync(role.Id) == null)
            {
                _logger.Error($"Role not found: {role.Id}");
                throw new InvalidOperationException("Role not found.");
            }

            await _roleRepository.UpdateAsync(role);

            _logger.Info($"Role updated successfully: {role.Id}");
        }

        public async Task DeleteRole(int id)
        {
            _logger.Info($"Deleting role Id={id}");

            if (await _roleRepository.GetByIdAsync(id) == null)
            {
                _logger.Error($"Role not found: {id}");
                throw new InvalidOperationException("Role not found.");
            }

            await _roleRepository.DeleteAsync(id);

            _logger.Info($"Role deleted successfully: {id}");
        }

        public async Task<IEnumerable<Role>> GetAll()
        {
            _logger.Info("Getting all roles");
            return await _roleRepository.GetAllAsync();
        }
        public async Task<Role?> GetById(int id)
        {
            _logger.Info($"Getting role Id {id}");
            return await _roleRepository.GetByIdAsync(id);
        }

        public async Task<bool> Exists(int id)
        {
            _logger.Info($"Checking if role Id {id} exists");
            return await _roleRepository.ExistsAsync(id);
        }
    }
}