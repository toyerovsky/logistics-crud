using Autofac;
using PSK.Databases.LogisticsCRUD.Startup;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PSK.Databases.LogisticsCRUD
{
    static class Program
    {
        public static Configuration Configuration { get; private set; }
        public static IContainer Container { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var startupProcedures = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IStartupProcedure).IsAssignableFrom(p));

            foreach (var startupProcedureType in startupProcedures)
            {
                var instance = (IStartupProcedure)Activator.CreateInstance(startupProcedureType);
                instance.Run();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<MainForm>());

            Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
    }
}
