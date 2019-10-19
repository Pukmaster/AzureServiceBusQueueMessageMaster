using System;
using System.Windows.Forms;

namespace Pukmaster.AzureServiceBusQueueReader.Forms
{
    public partial class AzureServiceBusSettingsForm : Form
    {
        private readonly ConnectionSettings _connectionSettings;

        public AzureServiceBusSettingsForm(ConnectionSettings connectionSettings)
        {
            InitializeComponent();

            _connectionSettings = connectionSettings;

            queueNameTextBox.Text = connectionSettings.QueueName;
            connectionStringTextBox.Text = connectionSettings.ConnectionString;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            _connectionSettings.QueueName = queueNameTextBox.Text;
            _connectionSettings.ConnectionString = connectionStringTextBox.Text;

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}