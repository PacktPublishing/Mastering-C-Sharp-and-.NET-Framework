using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_04_Lambda_
{
    public static class StringExtension
    {
        public static string ExtendedString(this string s)
        {
            return "{{ " + s + " }}";
        }
    }

    class LINQSyntax
    {
        static void Main(string[] args)
        {
            // generate a few numbers
            var numbers = Enumerable.Range(1, 2000);
            // use of linq to filter
            var selected = from n in numbers
                           where n % 3 == 0 && n % 7 == 0
                           select n;
            var totalNumbers = (from n in numbers
                                where n % 3 == 0 && n % 7 == 0
                                orderby n descending
                                select n).Count();
            var numbersStartingBy7 = from n in numbers
                                     where n.ToString().StartsWith("7")
                                     select n;
            //Console.WriteLine("Numbers divisible by 3 and 7 \n\r");
            // Now we use a lambda (Action) to print out results
            //selected.ToList().ForEach(n => Console.WriteLine("Selected: {0} ", n));
            //Console.Read();
            //LinqGroup();
            //LinqJoin();
            Console.WriteLine(" The word " + "evaluate".ExtendedString() + " is extended");
            Console.WriteLine();

        }

        private static void LinqGroup()
        {
            string[] words = { "Packt", "Publishing", "Editorial", "Books", "CSharp", "Chapter" };
            var wordsGrouped = from w in words
                               group w by w[0] into groupOfWords
                               select new { FirstLetter = groupOfWords.Key, Words = groupOfWords };
            Console.WriteLine(" List of words grouped by starting letter\n\r");
            foreach (var indGroup in wordsGrouped)
            {
                Console.WriteLine(" Starting with letter '{0}':", indGroup.FirstLetter);
                foreach (var word in indGroup.Words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }

        public static void LinqJoin()
        {
            // generate a few numbers
            var numbers = Enumerable.Range(1, 1000);
            var selected = from n in numbers
                           where n % 3 == 0 && n % 7 == 0
                           select n;
            var numbersStartingBy7 = from n in numbers
                                     where n.ToString().StartsWith("7")
                                     select n;
            var doubleMultiplesBeg7 = from n in selected
                                      join n7 in numbersStartingBy7 on n equals n7
                                      select n;
            var proj = from n in selected
                       join n7 in numbersStartingBy7 on n equals n7
                       select new { Num = n, DivBy2 = (n % 2 == 0) ? "Even" : "Odd" };

            //Console.WriteLine("Numbers divisible by 3 and 7 which start by 7\n\r");
            //doubleMultiplesBeg7.ToList().ForEach(n => Console.WriteLine("Selected: {0} ", n));
            Console.WriteLine("The same as before including another field");
            proj.ToList().ForEach(n => Console.WriteLine("Value: {0}, {1} ", n.Num, n.DivBy2));

            Console.Read();

        }

    }
}
