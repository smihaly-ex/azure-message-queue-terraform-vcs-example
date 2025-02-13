using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Receiver
{
    public class ReceiverFunction
    {
        private readonly ILogger<ReceiverFunction> _logger;

        public ReceiverFunction(ILogger<ReceiverFunction> logger)
        {
            _logger = logger;
        }

        // Function to receive a message from the queue
        [Function(nameof(ReceiverFunction))]
        public void Run([QueueTrigger("%QUEUE_NAME%", Connection = "AzureWebJobsStorage")] string message)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {message}");
        }
    }
}
