using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Class9Ex
{
    public class Sub2
    {
        public void SecondSubMsg(string message)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"The second subscriber received " +
                $"the message: {message} - via E-Mail.");
        }
    }
}
