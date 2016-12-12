using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace StackAndHeap
{
    class Program2
    {
        static void Main(string[] args)
        {
            string text;
            using (var reader = File.OpenText("Data.txt"))
            {
                text = reader.ReadToEnd();
            }
            Console.WriteLine(text);
            Console.Read();
        }

    }
}
