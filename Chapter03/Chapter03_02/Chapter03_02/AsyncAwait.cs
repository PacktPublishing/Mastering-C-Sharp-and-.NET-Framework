using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_02
{

    class AsyncAwait
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SlowMethod started at...{0}",
                                DateTime.Now.ToLongTimeString());
            SlowMethod();
            Console.WriteLine("Awaiting for SlowMethod...");
            Console.ReadLine();
        }
        static async Task SlowMethod()
        {
            // Simulation of slow method "Sleeping" the thread for 3 secs.
            await Task.Run(new Action(() => System.Threading.Thread.Sleep(3000)));
            Console.WriteLine("Finished at: {0}", DateTime.Now.ToLongTimeString());
            return;
        }

    }
}
