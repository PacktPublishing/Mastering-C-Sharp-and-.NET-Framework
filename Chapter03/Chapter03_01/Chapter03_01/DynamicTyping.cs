using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Chapter04_01
{
    class DynamicTyping
    {
        static void Main(string[] args)
        {
            //dynamic o = GetUnknownObject();
            //o.UnknownMethod();

            //object p = ReturnObjectType();
            //((T)p).UnknownMethod();

            // Dynamic by reflection.
            //dynamic dyn = "This is a dynamic declared string";
            //Type t = dyn.GetType();
            //PropertyInfo prop = t.GetProperty("Length");
            //int stringLength = prop.GetValue(dyn, new object[] { });
            //Console.WriteLine(dyn);
            //Console.WriteLine(stringLength);

            dynamic dyn = "This is a dynamic declared string";
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(dyn);
            Console.WriteLine(dyn.Length);
            Console.WriteLine(dyn.Toupper());
            Console.ReadLine();

        }
    }
}
