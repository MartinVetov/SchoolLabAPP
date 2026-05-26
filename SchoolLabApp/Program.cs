using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Services;
using SchoolLabApp.View;

namespace SchoolLabApp
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            var context = new SchoolLabAppDbContext();


            var userRepository = new UserRepository(context);
            var roleRepository = new RoleRepository(context);   

            var userService = new UserService(userRepository);
            var roleService = new RoleService(roleRepository);

            Application.Run(new Login(userService,roleService,context));
        }
    }
}
