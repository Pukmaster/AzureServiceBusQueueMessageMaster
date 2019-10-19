using System;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Pukmaster.AzureServiceBusQueueReader.Core;

namespace Pukmaster.AzureServiceBusQueueReader.Forms
{
    public class ServiceBusMessageHandler : IServiceBusMessageHandler
    {
        private readonly bool _completeMessages;
        private readonly Action<Message> _handleMessageAction;
        private readonly Action<string> _handleDisconnectionAction;

        public ServiceBusMessageHandler(bool completeMessages, Action<Message> handleMessageAction,
            Action<string> handleDisconnectionAction)
        {
            _completeMessages = completeMessages;
            _handleMessageAction = handleMessageAction;
            _handleDisconnectionAction = handleDisconnectionAction;
        }

        public async Task<bool> HandleMessageAsync(Message message)
        {
            _handleMessageAction(message);

            return false;
        }

        public void HandleDisconnection(string message)
        {
            _handleDisconnectionAction(message);
        }
    }
}