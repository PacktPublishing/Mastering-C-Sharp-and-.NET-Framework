using System;
using System.Collections.Generic;
using System.Linq;
/*
 * Note: Just comment/uncommnent sections of the code as you go along with the 
 * book's explanations. The whole C# 7 demos are included here.
 * Notice also the code about ref returns is all commented, since it's the 
 * "official" sample published by Microsoft.
 */

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            #region " Binary Literals and Digit Separators"
            int[] binNumbers = { 0b1, 0b10, 0b100, 0b1_000, 0b100_000, 123_456 };
            binNumbers.ToList().ForEach((n) => Console.WriteLine($"Item: {n}"));
            Console.Read();
            #endregion
            #region "Pattern Matching and Switch statements"
            var theValue = "123";
            var result = CheckNumber(theValue);
            var resultC7 = CheckNumberC7(theValue);
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result: {resultC7}");
            #endregion
            #region "Tuples"
            (int n, string s) t1 = (4, "data");
            var res = ProcessArray(binNumbers.ToList());
            // alternatively
            var (count, sum) = ProcessArray(binNumbers.ToList());
            Console.WriteLine($"Count: {res.count}");
            Console.WriteLine($"Sum: {res.sum}");
            #endregion
            #region "Decomposition"
            var (hour, minute, second) = DateTime.Now;
            Console.WriteLine($"Hour: {hour} - Minute: {minute} - Second: {second}");
            Console.Read();
            #endregion
        }

        static object CheckNumber(string s)
        {
            // If the string can be converted to int, we double 
            // the value. Otherwise, return it with a prefix
            int i = default(int);  // i must be initialized
            if (int.TryParse(s, out i))
            {
                return (i * 2);
            }
            else
            {
                return "NotInt_" + s;
            }
        }
        static object CheckNumberC7(string s)
        {
            // Now i is declared inside the If 
            if (int.TryParse(s, out int i))
                return (i * 2);
            else return "NotInt_" + s;
        }
        static object CheckObjectSwitch(object o)
        {
            var result = default(object);
            switch (o)
            {
                case null:
                    result = "null";
                    break;
                case int i:
                case string s when int.TryParse(s, out i):
                    result = i * 2;
                    break;
                case string v:
                    result = "NotInt_" + v;
                    break;
                default:
                    result = "Unknown value";
                    break;
            }
            return result;
        }

        static (int sum, int count) ProcessArray(List<int> numbers)
        {
            var result = (sum:0 , count:0);
            numbers.ForEach(n =>
            {
                result.count++;
                result.sum += n;
            });
            return result;
        }
        static (int sum, int count) ProcessArrayWithLocal(List<int> numbers)
        {
            var result = (s: 0, c: 0);
            foreach (var item in numbers)
            {
                ProcessItem(item, 1);
            }
            return result;
            void ProcessItem(int s, int c) { result.s+= s; result.c += c; };
        }
        static void Deconstruct(this DateTime dt, out int hour, 
                                out int minute, out int second)
        {
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }

        //public ref int Find(int number, int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] == number)
        //        {
        //            return ref numbers[i]; // return the storage location, not the value
        //        }
        //    }
        //    throw new IndexOutOfRangeException($"{nameof(number)} not found");
        //}

        //int[] array = { 1, 15, -39, 0, 7, 14, -12 };
        //ref int place = ref Find(7, array); // aliases 7's place in the array
        //place = 9; // replaces 7 with 9 in the array
        //WriteLine(array[4]); // prints 9
    }
}
