using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SchoolLabApp.Services
{
    public class DamageService
    {
        private readonly DamageRepository _damageRepository;
        private readonly Logger.Logger _logger;

        public DamageService(DamageRepository damageRepository,Logger.Logger logger)
        {  
            _damageRepository = damageRepository;
            _logger = logger;
        }
          

        public async Task AddDamage(int assetId, string description)
        {
            _logger.Info($"Adding damaged asset - asset Id {assetId}");

            if (string.IsNullOrWhiteSpace(description))
            {
                _logger.Warn("Adding damage failed: empty description");
                throw new ArgumentException("Description cannot be empty.");
            }

            var damage = new Damage
            {
                AssetId = assetId,
                Description = description,
                DateReported = DateTime.Now
            };

            await _damageRepository.AddAsync(damage);

            _logger.Info($"Damage added successfully: asset {assetId}");
        }

        public async Task UpdateDamage(Damage damage)
        {
            _logger.Info($"Updateing damage {damage.Id}");

            if (await _damageRepository.GetByIdAsync(damage.Id) == null)
            {
                _logger.Error($"Damage mot found {damage.Id}");
                throw new InvalidOperationException("Damage record not found.");
            }

            await _damageRepository.UpdateAsync(damage);

            _logger.Info($"Damage updated successfully: damageId {damage.Id}");
        }

        public async Task DeleteDamage(int id)
        {
            _logger.Info($"Deleting damage {id}");

            if (await _damageRepository.GetByIdAsync(id) == null)
            {
                _logger.Error($"Damage mot found {id}");
                throw new InvalidOperationException("Damage record not found.");
            }

            await _damageRepository.DeleteAsync(id);

            _logger.Info($"Damage deleted successfully: damageId {id}");
        }

        public async Task<IEnumerable<Damage>> GetAll()
        {
            _logger.Info("Getting all damages");
            return await _damageRepository.GetAllAsync();
        }
        public async Task<Damage?> GetById(int id)
        {
            _logger.Info($"Getting damage with {id} Id");
            return await _damageRepository.GetByIdAsync(id);
        }
    }
}