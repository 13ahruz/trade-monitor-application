using System;
using Microsoft.Extensions.DependencyInjection;
using TradeMonitorApp.Core.Configuration;
using TradeMonitorApp.Core.Loading;
using TradeMonitorApp.Core.Monitoring;
using TradeMonitorApp.Core.Services;
using TradeMonitorApp.GUI.ViewModels;
using TradeMonitorApp.GUI.Views;
using TradeMonitorApp.Loaders.CSV;
using TradeMonitorApp.Loaders.TXT;
using TradeMonitorApp.Loaders.XML;

namespace TradeMonitorApp.GUI
{
    public static class DependencyInjectionConfig
    {
        public static IServiceProvider Configure()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IConfigurationService, ConfigurationService>();
            services.AddSingleton<TradeDataService>();
            services.AddSingleton<LoaderFactory>();
            services.AddSingleton<DirectoryMonitor>();

            services.AddTransient<IFileLoader, CsvFileLoader>();
            services.AddTransient<IFileLoader, XmlFileLoader>();
            services.AddTransient<IFileLoader, TxtFileLoader>();

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();

            return services.BuildServiceProvider();
        }
    }
}
