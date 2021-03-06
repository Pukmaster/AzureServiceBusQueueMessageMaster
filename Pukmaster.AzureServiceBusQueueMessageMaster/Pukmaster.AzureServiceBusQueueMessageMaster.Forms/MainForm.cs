﻿using Newtonsoft.Json.Linq;
using Pukmaster.AzureServiceBusQueueMessageMaster.Core;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAS = Microsoft.Azure.ServiceBus;

namespace Pukmaster.AzureServiceBusQueueMessageMaster.Forms
{
    public partial class MainForm : Form
    {
        private readonly IServiceBusQueueMonitor _serviceBusQueueMonitor;
        private readonly IServiceBusMessageHandler _serviceBusMessageHandler;

        public MainForm(IServiceBusQueueMonitor serviceBusQueueMonitor)
        {
            InitializeComponent();

            _serviceBusQueueMonitor = serviceBusQueueMonitor;
            _serviceBusMessageHandler = new ServiceBusMessageHandler(false, AddMessageToListView, HandleDisconnection);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void connectButton_Click(object sender, System.EventArgs e)
        {
            ConnectToQueue();
        }

        private void ConnectToQueue()
        {
            var connectionSettings = new ConnectionSettings()
            {
            };

            var settingsForm = new AzureServiceBusSettingsForm(connectionSettings);
            settingsForm.ShowDialog();

            if (!string.IsNullOrWhiteSpace(connectionSettings.QueueName) && !string.IsNullOrWhiteSpace(connectionSettings.ConnectionString))
            {
                AddMessageToConsole("Connecting...");

                _serviceBusQueueMonitor.RegisterServiceBusQueueMonitor(connectionSettings.CompleteQueueName, connectionSettings.ConnectionString, _serviceBusMessageHandler);

                var connectionStringBuilder = new MAS.ServiceBusConnectionStringBuilder(connectionSettings.ConnectionString);

                connectedLabel.Text = $"Connected to: {connectionSettings.CompleteQueueName} @ {connectionStringBuilder.Endpoint}";

                AddMessageToConsole("Connected.");
            }
        }

        private Task AddMessageToListView(MAS.Message message)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { AddMessageToListView(message); });
                return Task.CompletedTask;
            }

            AddMessageToConsole("Received message.");

            listView1.Items.Add(CreateListViewItem(message));

            return Task.CompletedTask;
        }

        private void HandleDisconnection(string message)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { HandleDisconnection(message); });
                return;
            }

            connectedLabel.Text = "Disconnected";

            AddMessageToConsole(message);
        }

        private void AddMessageToConsole(string message)
        {
            var formattedMessage = $"{DateTime.Now} {message}";

            if (string.IsNullOrWhiteSpace(consoleTextBox.Text))
            {
                consoleTextBox.Text = formattedMessage;
            }
            else
            {
                consoleTextBox.Text = $"{formattedMessage}{Environment.NewLine}{consoleTextBox.Text}";
            }
        }

        private ListViewItem CreateListViewItem(MAS.Message message)
        {
            var listViewItem = new ListViewItem(message.MessageId);
            listViewItem.SubItems.Add(message.SystemProperties.EnqueuedTimeUtc.ToString());
            listViewItem.SubItems.Add(message.SystemProperties.SequenceNumber.ToString());
            listViewItem.Tag = message;

            return listViewItem;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var selectedMessage = e.Item.Tag as MAS.Message;

            if (selectedMessage != null)
            {
                payloadTextBox.Text = FormatPayload(Encoding.UTF8.GetString(selectedMessage.Body));
            }

            listView2.Items.Clear();

            var systemProperties = selectedMessage.SystemProperties;

            AddItemToPropertiesListView(nameof(systemProperties.DeadLetterSource), systemProperties.DeadLetterSource);
            AddItemToPropertiesListView(nameof(systemProperties.DeliveryCount), systemProperties.DeliveryCount.ToString());
            AddItemToPropertiesListView(nameof(systemProperties.EnqueuedSequenceNumber), systemProperties.EnqueuedSequenceNumber.ToString());
            AddItemToPropertiesListView(nameof(systemProperties.EnqueuedTimeUtc), systemProperties.EnqueuedTimeUtc.ToString());
            AddItemToPropertiesListView(nameof(systemProperties.IsLockTokenSet), systemProperties.IsLockTokenSet.ToString());
            AddItemToPropertiesListView(nameof(systemProperties.IsReceived), systemProperties.IsReceived.ToString());
            AddItemToPropertiesListView(nameof(systemProperties.LockedUntilUtc), systemProperties.LockedUntilUtc.ToString());
            AddItemToPropertiesListView(nameof(systemProperties.LockToken), systemProperties.LockToken);
            AddItemToPropertiesListView(nameof(systemProperties.SequenceNumber), systemProperties.SequenceNumber.ToString());

            foreach (var userProperty in selectedMessage.UserProperties)
            {
                AddItemToPropertiesListView(userProperty.Key, userProperty.Value.ToString());
            }
        }

        private string FormatPayload(string payload)
        {
            var parsedJson = JToken.Parse(payload);

            if (parsedJson != null)
            {
                return parsedJson.ToString();
            }

            return payload;
        }

        private void AddItemToPropertiesListView(string name, string value)
        {
            var listViewItem = new ListViewItem(name);
            listViewItem.SubItems.Add(value);

            listView2.Items.Add(listViewItem);
        }
    }
}