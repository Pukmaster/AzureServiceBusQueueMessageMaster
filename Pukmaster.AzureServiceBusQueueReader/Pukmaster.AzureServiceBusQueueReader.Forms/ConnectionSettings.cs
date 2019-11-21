namespace Pukmaster.AzureServiceBusQueueReader.Forms
{
    public class ConnectionSettings
    {
        private const string DeadLetterQueuePostfix = "/$deadletterqueue";

        public string QueueName { get; set; }

        public string ConnectionString { get; set; }

        public bool IsDeadLetterQueue { get; set; }

        public string CompleteQueueName
        {
            get
            {
                if (IsDeadLetterQueue && !QueueName.EndsWith(DeadLetterQueuePostfix))
                {
                    return $"{QueueName}{DeadLetterQueuePostfix}";
                }
                else
                {
                    return QueueName;
                }
            }
        }
    }
}