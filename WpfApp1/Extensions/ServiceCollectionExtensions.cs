using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using WpfApp1.Services;
using WpfApp1.ViewModels;

namespace WpfApp1.Extensions
{
    public static class ServiceCollectionExtensions
    {
        //public static void AddAppConfiguration(this IServiceCollection services)
        //{
        //    var configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //        .Build();

        //    services.AddSingleton<IConfiguration>(configuration);
        //}
        public static void AddAppConfiguration(this IServiceCollection services)
        {
            var configPath = @"D:\wpf-learning\FinalWPF\WpfApp1\appsettings.json"; // Replace with the actual path
            //var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException($"The configuration file 'appsettings.json' was not found at '{configPath}'.");
            }

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile(configPath, optional: false, reloadOnChange: true)
                .Build();

            services.AddSingleton<IConfiguration>(configuration);
        }

        public static void AddApiClient(this IServiceCollection services)
        {
            services.AddHttpClient<IApiClient, ApiClient>();
        }

        public static void AddViewModels(this IServiceCollection services)
        {
            services.AddTransient<LoginViewModel>();
            // Add other view models here as needed
        }
    }
}
