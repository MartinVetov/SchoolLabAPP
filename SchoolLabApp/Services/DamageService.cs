using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Services
{
    public class DamageService
    {
        private readonly DamageRepository _damageRepository;
        //TO DO: FIX THE DAMEGE AND ROLE SERVICE !!!!!!!!!!!!
        public DamageService(DamageRepository damageRepository)
        {
            _damageRepository = damageRepository;
        }

        public async Task<IEnumerable<Damage>> GetAllAsync()
        {
            return await _context.Damages
                .Include(d => d.Asset)
                .ToListAsync();
        }

        public async Task<Damage?> GetByIdAsync(int id)
        {
            return await _context.Damages
                .Include(d => d.Asset)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task AddAsync(Damage damage)
        {
            if (string.IsNullOrWhiteSpace(damage.Description))
                throw new ArgumentException("Description cannot be empty.");

            damage.DateReported = DateTime.UtcNow;

            await _context.Damages.AddAsync(damage);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Damage damage)
        {
            var exists = await _damageRepository.ExistsAsync(damage.Id);
            if (!exists)
            {
                throw new InvalidOperationException("Damage not found.");
            }
            await _damageRepository.UpdateAsync(damage);
        }

        public async Task DeleteAsync(int id)
        {
            var damage = await _context.Damages.FindAsync(id);
            if (damage != null)
            {
                _context.Damages.Remove(damage);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Damages.AnyAsync(d => d.Id == id);
        }
    }
}