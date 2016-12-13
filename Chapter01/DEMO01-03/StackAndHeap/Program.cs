using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace StackAndHeap
{
    class Program : IDisposable
    {
        static void Main(string[] args)
        {
            GenerateStrings();
            Console.WriteLine("Strings generated");
        }

        static void GenerateStrings()
        {
            string initialString = "Initial Data-";
            for (int i = 0; i < 5000; i++)
            {
                initialString += "-More data-";
            }
            Console.WriteLine("Strings generated");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    class Book
    {
        public string Title;
        public int Pages;
    }


}
