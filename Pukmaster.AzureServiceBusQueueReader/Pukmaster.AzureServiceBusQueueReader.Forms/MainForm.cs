using Pukmaster.AzureServiceBusQueueReader.Core;
using System.Windows.Forms;

namespace Pukmaster.AzureServiceBusQueueReader.Forms
{
    public partial class MainForm : Form
    {
        private readonly IServiceBusQueueMonitor _serviceBusQueueMonitor;

        public MainForm(IServiceBusQueueMonitor serviceBusQueueMonitor)
        {
            InitializeComponent();

            _serviceBusQueueMonitor = serviceBusQueueMonitor;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            
        }

        private void connectButton_Click(object sender, System.EventArgs e)
        {

        }

        private void ConnectToQueue()
        {
            var queueName = "";
            var connectionString = "";

            _serviceBusQueueMonitor.RegisterServiceBusQueueMonitor(queueName, connectionString);
        }
    }
}