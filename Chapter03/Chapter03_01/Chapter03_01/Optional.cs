using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter04_01
{
    class Optional
    {
        static void Main()
        {
            RepeatStringOptional(3, "Greetings");
            RepeatStringOptional(5);
            Console.Read();
        }

        static void RepeatStringOptional(int x, string text = "Message")
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("String no {0}: {1}", i, text);
            }
        }
    }
}
