using InventoryManagement.Screens;
using InventoryManagement.Services;
using InventoryManagement.Services.UserServices;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetDefaultFont(new System.Drawing.Font("Segoe UI Variable Display Semibold", 11));

            var services = new ServiceCollection();
            // DI Services
            services.AddTransient<MDI>();
            services.AddSingleton<ICRUD, UserService>();

            // End Di Services
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var mdi = serviceProvider.GetRequiredService<MDI>();
            
            //ApplicationConfiguration.Initialize();
            Application.Run(mdi);
        }
    }
}