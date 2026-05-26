using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Services
{
    public class DamageService
    {
        private readonly DamageRepository _damageRepository;

        public DamageService(DamageRepository damageRepository)
        {
            _damageRepository = damageRepository;
        }

        public async Task<IEnumerable<Damage>> GetAllAsync()
        {
            return await _damageRepository.GetAllAsync();
        }

        public async Task<Damage?> GetByIdAsync(int id)
        {
            return await _damageRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Damage damage)
        {
            if (string.IsNullOrWhiteSpace(damage.Description))
                throw new ArgumentException("Description cannot be empty.");

            damage.DateReported = DateTime.UtcNow;

            await _damageRepository.AddAsync(damage);
        }

        public async Task UpdateAsync(Damage damage)
        {
            var exists = await _damageRepository.ExistsAsync(damage.Id);
            if (!exists)
                throw new InvalidOperationException("Damage not found.");

            await _damageRepository.UpdateAsync(damage);
        }

        public async Task DeleteAsync(int id)
        {
            await _damageRepository.DeleteAsync(id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _damageRepository.ExistsAsync(id);
        }
    }
}