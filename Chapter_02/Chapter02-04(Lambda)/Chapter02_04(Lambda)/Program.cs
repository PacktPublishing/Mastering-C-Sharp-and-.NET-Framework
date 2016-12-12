using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_04_Lambda_
{
    class Program
    {
        static List<int> numberList;
        static List<int> divisibleNumbers = new List<int>();
        static List<int> selectedNumbers = new List<int>();
        static void Main(string[] args)
        {
            // Anonymous object
            //var obj = new { Name = "John", Age = 35 };

            // Generic delegate way
            numberList = Enumerable.Range(1, 100).ToList();
            ClassicDelegateMethod();
            PrintResults("Numbers divisible by 3 and 7");

            numberList = Enumerable.Range(101, 200).ToList();
            CallWithLambdas();
            PrintResults("Numbers divisible by 3 and 7");
            Console.Read();
        }
        private static void PrintResults(string header)
        {
            Console.WriteLine(header);
            Console.WriteLine("".PadRight(header.Length, '-'));
            foreach (var item in divisibleNumbers)
            {
                Console.WriteLine("selected: {0}", item);
            }
            Console.Read();
        }
        private static void CallWithLambdas()
        {
            // method Where in generic lists 
            numberList = numberList.Where(x => ((x % 3 == 0) || (x % 7 == 0))).ToList();
        }

        #region "Classic delegates"
        // Advantages of delegates:
        // 1) Invoke a method calling the delegate
        // 2) Multicast means several potential receivers 
        //    called in sequence
        // 3) It's a communication mechanism totally configurable
        delegate void DivisibleBy(int numero);
        static private void ClassicDelegateMethod()
        {
            DivisibleBy ed = new DivisibleBy(CheckMod3);
            // Invocation of several methods (Multicasting)
            ed += CheckMod7;
            // Every call to ed generates a multicast sequence 
            foreach (int x in numberList) { ed(x); }
        }
        static private void CheckMod3(int x)
        {
            // This might not be so trivial...
            if (x % 3 == 0) divisibleNumbers.Add(x);
        }
        static private void CheckMod7(int x)
        {
            // This might not be so trivial...
            // We can avoid adding repeated numbers
            if (x % 3 == 0) return;
            if (x % 7 == 0) divisibleNumbers.Add(x);
        }
        #endregion
        #region "Using Actions y Funcs"
        private void Actions()
        {
            List<int> numberList = Enumerable.Range(1, 1000).ToList();
            Func<int, bool> DivisibleBy3 = (n) => (n % 3 == 0);
            numberList = numberList.Where(DivisibleBy3).ToList();
            // We can create a more complex function including 
            // any number of conditions
            Action<int> MultipleConditions = n =>
            {
                if ((n % 3 == 0) && (n % 2 == 0))
                {
                    if (n.ToString().StartsWith("5")) selectedNumbers.Add(n);
                }
            };
            numberList.ForEach(MultipleConditions);
        }
        #endregion
    }
}
