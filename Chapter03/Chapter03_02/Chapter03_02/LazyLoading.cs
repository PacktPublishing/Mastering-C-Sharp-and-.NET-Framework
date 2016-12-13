using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter03_03
{ 

    class LazyLoading
    {
        static List<Customer> Customers;
        static List<Lazy<Customer>> CustomersLazy;
        static void Main()
        {

            Stopwatch watchLazy = Stopwatch.StartNew();
            CustomersLazy = new Customer().getCustomersLazy();
            watchLazy.Stop();
            Console.WriteLine(" Generation of Customers (Lazy Version)");
            Console.WriteLine((" ").PadRight(39, '-'));
            Console.WriteLine(" Total time (milliseconds): " + 
                watchLazy.Elapsed.TotalMilliseconds);
            Console.WriteLine();

            Console.WriteLine(" Generation of Customers (non-lazy)");
            Console.WriteLine((" ").PadRight(39, '-'));
            Stopwatch watch = Stopwatch.StartNew();
            Customers = new Customer().getCustomers();
            watch.Stop();
            Console.WriteLine(" Total time (milliseconds): " + 
                watch.Elapsed.TotalMilliseconds);

            Console.ReadLine();
        }
        public class Customer
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
            public double Balance { get; set; }
            public Customer()
            {
                // We forze a delay for testing purposes
                Thread.Sleep(100);
            }
            public List<Customer> getCustomers()
            {
                string[] names = File.ReadAllLines("ListOfNames.txt");
                string[] cities = { "New York", "Los Angeles", "Chicago", "New Orleans" };
                int totalCustomers = names.Length;
                List<Customer> list = new List<Customer>();
                Random r = new Random(DateTime.Now.Millisecond);
                for (int i = 1; i < totalCustomers; i++)
                {
                    list.Add(new Customer()
                    {
                        Code = i,
                        Balance = r.Next(0, 10000),
                        Name = names[r.Next(1, 50)],
                        City = cities[r.Next(0, 4)]
                    });
                }
                return list;
            }

            public List<Lazy<Customer>> getCustomersLazy()
            {
                string[] names = File.ReadAllLines("ListOfNames.txt");
                string[] cities = { "New York", "Los Angeles", "Chicago", "New Orleans" };
                int totalCustomers = names.Length;
                List<Lazy<Customer>> list = new List<Lazy<Customer>>();
                Random r = new Random(DateTime.Now.Millisecond);
                for (int i = 1; i < totalCustomers; i++)
                {
                    list.Add(new Lazy<Customer>(() => new Customer()
                    {
                        Code = i,
                        Balance = r.Next(0, 10000),
                        Name = names[r.Next(1, 50)],
                        City = cities[r.Next(1, 4)]
                    }));
                }
                return list;
            }
        }
    }
}
