using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;

namespace Pukmaster.AzureServiceBusQueueMessageMaster.Core
{
    public interface IServiceBusMessageHandler
    {
        Task<bool> HandleMessageAsync(Message message);

        void HandleDisconnection(string message);
    }
}