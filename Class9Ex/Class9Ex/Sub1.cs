using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Class9Ex
{
    // Subscriber 1 Class;
    public class Sub1
    {
        // Sub Method - Message and Thread;
        public void FirstSubMsg(string message)
        {

            Thread.Sleep(3000);
            Console.WriteLine($"The first subscriber received " +
                $"the message: {message} - via SMS.");
        }
    }
}
