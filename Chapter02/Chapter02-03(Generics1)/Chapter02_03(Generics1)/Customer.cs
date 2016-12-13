using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter02_03_Generics1_
{
    public class T
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Balance { get; set; }

        public static string[] Countries = { "US", "UK", "India", "Canada", "China" };
        public static List<T> customersList(int number)
        {
            List<T> list = new List<T>();
            Random rnd = new Random(System.DateTime.Now.Millisecond);
            for (int i = 1; i <= number; i++)
            {
                T c = new T();
                c.Name = Path.GetRandomFileName().Replace(".", "");
                c.Country = Countries[rnd.Next(0, 4)];
                c.Balance = rnd.Next(0, 100000);
                list.Add(c);
            }
            return list;
        }

    }
    public class CustomerComparer : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            // Implementation of IComparer returns an int 
            // indicating if object x is less than, equal to or 
            // greater than y.
            if (x.Balance < y.Balance) { return -1; }
            else if (x.Balance > y.Balance) return 1;
            else { return 0; } // they're equal
        }
    }
    public class GenericCustomers
    {
        public static void Main()
        {
            List<T> theList = T.customersList(25);
            CustomerComparer cc = new CustomerComparer();
            // Sort now uses our own definition of comparison
            theList.Sort(cc);
            Console.WriteLine("List of customers ordered by Balance");
            Console.WriteLine(("").PadRight(36, '-')); // prints out 36 dashes...
            
            foreach (var item in theList)
            {
                Console.WriteLine(" Name: {0},  Country: {1}, \t Balance: {2,8:C}",
                    item.Name, item.Country, item.Balance);
            }
            Console.ReadKey();
        }
    }
}
