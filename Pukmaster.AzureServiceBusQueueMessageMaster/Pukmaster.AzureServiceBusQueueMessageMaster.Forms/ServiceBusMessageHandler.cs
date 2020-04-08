using System;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Pukmaster.AzureServiceBusQueueMessageMaster.Core;

namespace Pukmaster.AzureServiceBusQueueMessageMaster.Forms
{
    public class ServiceBusMessageHandler : IServiceBusMessageHandler
    {
        private readonly bool _completeMessages;
        private readonly Func<Message, Task> _handleMessageActionAsync;
        private readonly Action<string> _handleDisconnectionAction;

        public ServiceBusMessageHandler(bool completeMessages, Func<Message, Task> handleMessageActionAsync,
            Action<string> handleDisconnectionAction)
        {
            _completeMessages = completeMessages;
            _handleMessageActionAsync = handleMessageActionAsync;
            _handleDisconnectionAction = handleDisconnectionAction;
        }

        public async Task<bool> HandleMessageAsync(Message message)
        {
            await _handleMessageActionAsync(message);

            return false;
        }

        public void HandleDisconnection(string message)
        {
            _handleDisconnectionAction(message);
        }
    }
}