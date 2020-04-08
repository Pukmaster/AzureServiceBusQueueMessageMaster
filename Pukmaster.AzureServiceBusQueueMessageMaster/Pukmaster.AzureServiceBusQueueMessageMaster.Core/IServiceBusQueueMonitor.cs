using System.Threading.Tasks;

namespace Pukmaster.AzureServiceBusQueueMessageMaster.Core
{
    public interface IServiceBusQueueMonitor
    {
        void RegisterServiceBusQueueMonitor(string queueName, string serviceBusConnectionString, IServiceBusMessageHandler serviceBusMessageHandler);

        Task DeregisterServiceBusQueueMonitorAsync(string message);
    }
}