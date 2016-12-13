using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskCancellation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WindowWidth = 39;
            Console.WriteLine("Operation started...");
            var cs = new CancellationTokenSource();
            var t = Task.Factory.StartNew(
                () => DoALongWork(cs)
                );
            Thread.Sleep(500);
            cs.Cancel();
            Console.Read();
        }

        private static void DoALongWork(CancellationTokenSource cs)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(10);
                    cs.Token.ThrowIfCancellationRequested();
                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine("Operation Cancelled. \n Cancellation requested: " + 
                    ex.CancellationToken.IsCancellationRequested);
            }
        }


    }
}
