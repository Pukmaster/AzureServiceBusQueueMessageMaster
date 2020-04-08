using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pukmaster.AzureServiceBusQueueMessageMaster.Core
{
    public class ServiceBusQueueMonitor : IServiceBusQueueMonitor
    {
        private readonly ILogger _log;
        private IQueueClient _queueClient;
        private IServiceBusMessageHandler _serviceBusMessageHandler;

        public string QueueName { get; private set; }

        public ServiceBusQueueMonitor(ILogger log)
        {
            _log = log;
        }

        public void RegisterServiceBusQueueMonitor(string queueName, string serviceBusConnectionString, IServiceBusMessageHandler serviceBusMessageHandler)
        {
            QueueName = queueName;
            _queueClient = new QueueClient(serviceBusConnectionString, queueName);
            _serviceBusMessageHandler = serviceBusMessageHandler;

            RegisterOnMessageHandlerAndReceiveMessages();
        }

        public async Task DeregisterServiceBusQueueMonitorAsync(string message)
        {
            await _queueClient.CloseAsync();

            _serviceBusMessageHandler.HandleDisconnection(message);
        }

        private void RegisterOnMessageHandlerAndReceiveMessages()
        {
            var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            };

            _queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
        }

        private async Task ProcessMessagesAsync(Message message, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                return;
            }

            var result = await _serviceBusMessageHandler.HandleMessageAsync(message);

            if (result)
            {
                await _queueClient.CompleteAsync(message.SystemProperties.LockToken);
            }
        }

        private async Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            // https://github.com/Azure/azure-sdk-for-net/issues/6410
            var canceledException = exceptionReceivedEventArgs.Exception as OperationCanceledException;

            if (canceledException != null && canceledException.CancellationToken.IsCancellationRequested)
            {
                return;
            }

            // https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/servicebus/Microsoft.Azure.ServiceBus/src/Management/ManagementClient.cs
            if (exceptionReceivedEventArgs.Exception is MessagingEntityNotFoundException)
            {
                await DeregisterServiceBusQueueMonitorAsync(exceptionReceivedEventArgs.Exception.Message);
                return;
            }
        }
    }
}