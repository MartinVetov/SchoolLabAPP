using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;

namespace SchoolLabApp.Repositories.Implementations
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SchoolLabAppDbContext context) : base(context)
        {
        }

        public async Task UpdateAsync(User user)
        {
            var oldUser = await _context.Users.FindAsync(user.Id);

            if (oldUser == null)
            {
                throw new InvalidOperationException("Asset not found.");
            }

            oldUser.Username = user.Username;
            oldUser.Password = user.Password;
            oldUser.Role = user.Role;
            oldUser.RoleId = user.RoleId;
            _context.Users.Add(oldUser);
            await _context.SaveChangesAsync();
        }
        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _dbSet
                .Include(u => u.Role)
                .Include(u => u.Person)
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User?> LoginAsync(string username, string password)
        {
            return await _dbSet
                .Include(u => u.Role)
                .Include(u => u.Person)
                .FirstOrDefaultAsync(u =>
                    u.Username == username &&
                    u.Password == password);
        }
    }
}