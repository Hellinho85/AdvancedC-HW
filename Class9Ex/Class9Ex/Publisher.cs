using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Class9Ex
{
    // Main Publisher delegate - publishing message;
    public delegate void PublisherMessageDelegate(string message);

    public class Publisher
    {

        // Event Handler;
        public event PublisherMessageDelegate EventMessageHandler;

        // Message Method;
        public void ComposeMessage(string trainerName, string groupNumber, string message)
        {
            SendMessage($"TrainerName: {trainerName}, " +
                $"GroupNumber: {groupNumber}, Message: {message}.");
        }

        // Virtual Method - publishing message;
        public virtual void SendMessage(string message)
        {
            EventMessageHandler?.Invoke(message);
        }

    }
}
