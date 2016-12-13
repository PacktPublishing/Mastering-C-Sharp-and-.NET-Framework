using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_02
{

    class GenericTask
    {
        static void Main(string[] args)
        {
            Task<string> t = Task.Factory.StartNew<string>(
                () => SlowMethod());
            Console.WriteLine("Waiting for SlowMethod to finish...");
            t.Wait();
            Console.WriteLine("Finished at: {0}", t.Result);
            Console.ReadLine();
        }
        static string SlowMethod()
        {
            System.Threading.Thread.Sleep(3000);
            return DateTime.Now.ToLongTimeString();
        }
    }
}
