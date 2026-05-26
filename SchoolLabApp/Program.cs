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
            // 
                //if (!context.Roles.Any())
                //{
                //    await context.Roles.AddRangeAsync(
                //        new Role { Name = "Admin" },
                //        new Role { Name = "Teacher" },
                //        new Role { Name = "Student" },
                //        new Role { Name = "Technician" }
                //    );

                //    await context.SaveChangesAsync();
                //}
            


            var userRepository = new UserRepository(context);

            var userService = new UserService(userRepository);
            var roleService = new RoleService(context);

            //Application.Run(new Login(userService,roleService,context));
            Application.Run(new ReportPanel());
        }
    }
}
