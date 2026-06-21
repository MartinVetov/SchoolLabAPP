using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;
using SchoolLabApp.Data;
using SchoolLabApp.Logger;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Services;
using SchoolLabApp.View;
using System.Reflection;

namespace SchoolLabApp
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Logger","log4net.config");

            var repository = LogManager.GetRepository(Assembly.GetExecutingAssembly());

            XmlConfigurator.Configure(repository, new FileInfo(configPath));


            Logger.Logger logger = new Logger.Logger();
            using var context = new SchoolLabAppDbContext();

            var userRepository = new UserRepository(context);
            var roleRepository = new RoleRepository(context);
            var personRepostitory = new PersonRepository(context);

            var userService = new UserService(userRepository, logger);
            var roleService = new RoleService(roleRepository);
            var personService = new PersonService(personRepostitory);

            logger.Info("App started");


            Application.Run(new Login(userService, roleService, context, personService));
        }
    }
}

