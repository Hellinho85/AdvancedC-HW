using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Class9Ex
{
    public class Sub3
    {
        public void ThirdSubMsg(string message)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"The third subscriber received " +
                $"the message: {message} - via Facebook.");
        }
    }
}
