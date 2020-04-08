using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pukmaster.AzureServiceBusQueueMessageMaster.Core;
using System;
using System.Windows.Forms;

namespace Pukmaster.AzureServiceBusQueueMessageMaster.Forms
{
    static class Program
    {
        private static IServiceProvider _serviceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();

            var serviceBusQueueMonitor = _serviceProvider.GetService<IServiceBusQueueMonitor>();

            Application.Run(new MainForm(serviceBusQueueMonitor));
        }

        private static void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddLogging();

            serviceCollection.AddScoped<ILogger, CustomLogger>();
            serviceCollection.AddScoped<IServiceBusMessageHandler, ServiceBusMessageHandler>();
            serviceCollection.AddScoped<IServiceBusQueueMonitor, ServiceBusQueueMonitor>();

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}