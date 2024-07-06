using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using WpfApp1.Extensions;
using WpfApp1.Services;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public IServiceProvider Services { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddAppConfiguration();
            serviceCollection.AddApiClient();
            serviceCollection.AddViewModels();

            // Register MainWindow as a service
            serviceCollection.AddSingleton<MainWindow>();

            Services = serviceCollection.BuildServiceProvider();

            var mainWindow = Services.GetRequiredService<MainWindow>();
            mainWindow.Show();

            
        }
    }

}
