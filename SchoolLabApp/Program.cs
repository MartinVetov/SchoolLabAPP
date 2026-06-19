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

            using var context = new SchoolLabAppDbContext();

            var userRepository = new UserRepository(context);
            var roleRepository = new RoleRepository(context);
            var personRepostitory = new PersonRepository(context);

            var userService = new UserService(userRepository);
            var roleService = new RoleService(roleRepository);
            var personService = new PersonService(personRepostitory);

            Application.Run(new Login(userService,roleService,context,personService));
        }
    }
}
