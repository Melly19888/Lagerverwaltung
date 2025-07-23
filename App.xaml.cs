using System.Windows;
using Microsoft.EntityFrameworkCore;
using LagerverwaltungApp.Data;

namespace LagerverwaltungApp
{
    public partial class App : Application
    {
        public static AppDbContext DbContext { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Hier konfigurieren wir den DbContext für EF Core 3.1
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(
                "Server=tcp:dbmelanie.database.windows.net,1433;" +
                "Initial Catalog=LagerDB;" +
                "Persist Security Info=False;" +
                "User ID=dbAdmin;" +
                "Password=Noah.2013;" +
                "MultipleActiveResultSets=False;" +
                "Encrypt=True;" +
                "TrustServerCertificate=True;" +
                "Connection Timeout=30;");

            DbContext = new AppDbContext(optionsBuilder.Options);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
