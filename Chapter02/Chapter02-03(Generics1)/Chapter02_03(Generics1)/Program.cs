using System;
using System.Collections.Generic;
using System.Linq;
namespace Chapter02_03_Generics1_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\r\n--- Create a concrete type from a generic Dictionary.");

            // Define a generic Dictionary (the 
            // comma is enough for the compiler to infer number of 
            // parameters, but we didn't decide the types yet.
            Type generic = typeof(Dictionary<,>);
            ShowTypeData(generic);

            // Now we can define an array of types for the Dictionary (Key, Value)
            // Key is of type string, and Value is of -this- type (Program)
            // Notice that types could be -in this case- of any kind
            Type[] typeArgs = { typeof(string), typeof(Program) };

            // Now we use MakeGenericType to create a Type representing 
            // the actualType generic type.
            Type actualType = generic.MakeGenericType(typeArgs);
            ShowTypeData(actualType);

            // Compare types obtained above to type objects
            // obtained using typeof() and GetGenericTypeDefinition().
            Console.WriteLine("\r\n--- Comparison of types generated differently:");

            Type t = typeof(Dictionary<String, Program>);
            Console.WriteLine("\tConstructed types equal? {0}", t == actualType);
            Console.WriteLine("\tGeneric types equal? {0}",
                t.GetGenericTypeDefinition() == generic);
            Console.Read();
        }
        private static void ShowTypeData(Type t)
        {
            Console.WriteLine("\r\n{0}", t);
            Console.WriteLine("\tGeneric type definition? {0}",
                t.IsGenericTypeDefinition);
            Console.WriteLine("\tGeneric type? {0}", 
                t.IsGenericType);

            Type[] typeArguments = t.GetGenericArguments();
            Console.WriteLine("\tList of arguments ({0}):", typeArguments.Length);
            foreach (Type tParam in typeArguments)
            {
                Console.WriteLine("\t\t{0}", tParam);
            }
        }
    }
}
