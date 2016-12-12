using System;
using System.Threading.Tasks;

namespace Chapter03_02
{
    class Program
    {
        public static string theString = "";
        static void Main(string[] args)
        {
            Task t = new Task(() =>
            {
                SlowMethod(ref theString);
            });
            t.Start();
            Console.WriteLine("Waiting for SlowMethod to finish...");
            t.Wait();
            Console.WriteLine("Finished at: {0}",theString);
            Console.ReadLine();
        }

        static void SlowMethod(ref string value)
        {
            System.Threading.Thread.Sleep(3000);
            value = DateTime.Now.ToLongTimeString();
        }
    }
}
