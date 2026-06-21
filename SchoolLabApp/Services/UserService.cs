using Microsoft.VisualBasic.ApplicationServices;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using User = SchoolLabApp.Models.User;

namespace SchoolLabApp.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly Logger.Logger _logger;

        private User? _currentUser;

        public UserService(UserRepository userRepository, Logger.Logger logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task Register(User user)
        {
            _logger.Info($"Register attempt: {user?.Username}");
            if (user == null)
            {
                _logger.Error("User object is null.");
                throw new ArgumentNullException(nameof(user));
            }

            if (string.IsNullOrWhiteSpace(user.Username))
            {
                _logger.Warn("Register failed: Empty username.");
                throw new ArgumentException("Username is required.");
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                _logger.Warn($"Register failed for {user.Username}: Empty password.");
                throw new ArgumentException("Password is required.");
            }

            if (user.RoleId <= 0)
            {
                _logger.Warn($"Register failed for {user.Username}: Role was not selected");
                throw new ArgumentException("A valid role must be selected.");
            }

            var existing = await _userRepository.GetByUsernameAsync(user.Username);

            if (existing != null)
            {
                _logger.Warn($"Register failed: Username '{user.Username}' already exists.");
                throw new InvalidOperationException("Username already exists.");
            }

            await _userRepository.AddAsync(user);
        }

        public async Task<User> Login(string username, string password)
        {

            if (string.IsNullOrWhiteSpace(username))
            {
                _logger.Warn($"Login failed: Empty username");
                throw new ArgumentException("Username is required.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                _logger.Warn($"Login failed: Empty password");
                throw new ArgumentException("Password is required.");
            }

            _logger.Info($"Login attempt: {username}");
            var user = await _userRepository.LoginAsync(username, password);

            if (user == null)
            {
                _logger.Warn($"Login failed: {username}");
                throw new InvalidOperationException("Invalid username or password.");
            }
            _currentUser = user;

            _logger.Info($"Successful login: {user.Username}| Password: {user.Password} | Role: {user.Role?.Name}");

            return user;
        }

        public int GetCurrentUserId()
        {
            _logger.Info($"Geting current user ID");

            if (_currentUser == null)
            {
                _logger.Warn($"No current user");
                throw new InvalidOperationException("No user is logged in.");
            }

            _logger.Info($"Returing current user ID - {_currentUser.Id}");
            return _currentUser.Id;
        }

        public User? GetCurrentUser()
        {
            _logger.Info($"Current user is {_currentUser.Username}");
            return _currentUser;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            _logger.Info("Geting all users");
            return await _userRepository.GetAllUsersWithRolesAsync();
        }

        public async Task UpdateUser(User user)
        {
            _logger.Info($"Updating user with Id={user.Id}");

            if (await _userRepository.GetByIdAsync(user.Id) == null)
            {
                _logger.Error($"User not found the id is null.");
                throw new InvalidOperationException("User not found.");
            }
            await _userRepository.UpdateAsync(user);
            _logger.Info($"Successfully updated user: {user.Id}");
        }

        public async Task DeleteUser(int id)
        {
            _logger.Info($"Deleting user Id={id}");

            if (await _userRepository.GetByIdAsync(id) == null)
            {
                _logger.Error($"User not found the id is null.");
                throw new InvalidOperationException("User not found.");
            }

            await _userRepository.DeleteAsync(id);
            _logger.Info($"User deleted successfully: {id}");
        }

        public async Task<User?> GetById(int id)
        {
            _logger.Info($"Geting user by Id: {id}");
            if (await _userRepository.GetByIdAsync(id) == null)
            {
                _logger.Warn($"User not found the id is null.");
                throw new InvalidOperationException("User not found.");
            }
            _logger.Info($"Returnig user I d: {id}");
            return await _userRepository.GetByIdAsync(id);
        }
        public void Logout()
        {
            _logger.Info($"{_currentUser.Username} is loging out");
            _currentUser = null;
            _logger.Info($"Current user is {_currentUser}");
        }
    }
}
