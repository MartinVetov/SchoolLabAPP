using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
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
          

        public async Task AddDamage(int assetId, string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description cannot be empty.");
            }

            var damage = new Damage
            {
                AssetId = assetId,
                Description = description,
                DateReported = DateTime.Now
            };
            await _damageRepository.AddAsync(damage);
        }

        public async Task UpdateDamage(Damage damage)
        {
            if (await _damageRepository.GetByIdAsync(damage.Id) == null)
            {
                throw new InvalidOperationException("Damage record not found.");
            }
            await _damageRepository.UpdateAsync(damage);
        }

        public async Task DeleteDamage(int id)
        {
            if (await _damageRepository.GetByIdAsync(id) == null)
            {
                throw new InvalidOperationException("Damage record not found.");
            }
            await _damageRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Damage>> GetAll()
        {
            return await _damageRepository.GetAllAsync();
        }
        public async Task<Damage?> GetById(int id)
        {
            return await _damageRepository.GetByIdAsync(id);
        }
    }
}