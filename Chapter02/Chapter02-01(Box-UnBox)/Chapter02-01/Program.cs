using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = DateTime.Now;
            // Boxing and Unboxing
            int y = 3; // this is declared in the stack
            // Boxing y in a Heap reference z
            // If we change z, y remains the same.
            object z = y;
            // Unboxing y into h (the value of 
            // z is copied to the stack)
            int h = (int)z;

        }
    }
}
