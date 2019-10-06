using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace Pukmaster.AzureServiceBusQueueReader.Core
{
    public class ServiceBusMessageHandler : IServiceBusMessageHandler
    {
        public async Task<bool> HandleMessageAsync(Message message)
        {
            return true;
        }
    }
}