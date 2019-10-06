using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;

namespace Pukmaster.AzureServiceBusQueueReader.Core
{
    public interface IServiceBusMessageHandler
    {
        Task<bool> HandleMessageAsync(Message message);
    }
}