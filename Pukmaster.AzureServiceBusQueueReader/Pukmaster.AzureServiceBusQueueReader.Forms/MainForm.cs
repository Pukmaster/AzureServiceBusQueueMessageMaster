using Pukmaster.AzureServiceBusQueueReader.Core;
using System;
using System.Text;
using System.Windows.Forms;
using MAS = Microsoft.Azure.ServiceBus;

namespace Pukmaster.AzureServiceBusQueueReader.Forms
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
                QueueName = "",
                ConnectionString = ""
            };

            var settingsForm = new AzureServiceBusSettingsForm(connectionSettings);
            settingsForm.ShowDialog();

            _serviceBusQueueMonitor.RegisterServiceBusQueueMonitor(connectionSettings.QueueName, connectionSettings.ConnectionString, _serviceBusMessageHandler);

            var connectionStringBuilder = new MAS.ServiceBusConnectionStringBuilder(connectionSettings.ConnectionString);

            connectedLabel.Text = $"Connected to: {connectionSettings.QueueName} @ {connectionStringBuilder.Endpoint}";
        }

        private void AddMessageToListView(MAS.Message message)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { AddMessageToListView(message); });
                return;
            }

            listView1.Items.Add(CreateListViewItem(message));
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
            consoleTextBox.Text = $"{message}{Environment.NewLine}{consoleTextBox.Text}";
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
                payloadTextBox.Text = Encoding.UTF8.GetString(selectedMessage.Body);
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
        }

        private void AddItemToPropertiesListView(string name, string value)
        {
            var listViewItem = new ListViewItem(name);
            listViewItem.SubItems.Add(value);

            listView2.Items.Add(listViewItem);
        }
    }
}