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
            deadLetterQueueCheckBox.Checked = connectionSettings.IsDeadLetterQueue;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            _connectionSettings.QueueName = queueNameTextBox.Text;
            _connectionSettings.ConnectionString = connectionStringTextBox.Text;
            _connectionSettings.IsDeadLetterQueue = deadLetterQueueCheckBox.Checked;

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}