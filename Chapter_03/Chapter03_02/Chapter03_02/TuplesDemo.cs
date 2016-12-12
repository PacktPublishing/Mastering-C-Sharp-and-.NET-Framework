using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_03
{
    //Tuple.Create(1, 2, 3, 4, 5);
    //new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
    //Tuple.Create("Hello", DateTime.Today, 99, 3.3);

    class TuplesDemo
    {
        static List<Customer> Customers;
        static IEnumerable<Tuple<int, string, double>> Balances;

        static void Main()
        {
            Customers = new Customer().getCustomers();
            Balances = CustBalance("Chicago");
            Printout();
            Console.ReadLine();
        }
        static IEnumerable<Tuple<int, string, double>> CustBalance(string city)
        {
            var result =
                from c in Customers
                where c.City == city
                orderby c.Code, c.Balance
                select Tuple.Create(c.Code, c.Name, c.Balance);
            return result;
        }
        static void Printout()
        {
            string formatString = " Code: {0,-6} Name: {1,-20} Balance: {2,10:C2}";
            Console.WriteLine(" Balance: Customers from Chicago");
            Console.WriteLine((" ").PadRight(32, '-'));
            foreach (var f in Balances)
                Console.WriteLine(formatString, f.Item1, f.Item2, f.Item3);
        }
        public class Customer
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
            public double Balance { get; set; }
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
                        City = cities[r.Next(1, 4)]
                    });
                }
                return list;
            }

        }
    }
}
