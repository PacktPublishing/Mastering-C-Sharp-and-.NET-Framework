using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass t = new SimpleClass();
            Console.Read();
        }
    }

    class SimpleClass
    {
        public string data { get; set; }
        public int num { get; set; }
    }
}
