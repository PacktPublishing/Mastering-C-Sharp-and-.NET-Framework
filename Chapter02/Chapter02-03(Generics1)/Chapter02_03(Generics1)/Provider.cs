using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter02_03_Generics1_
{
    public class Provider : IPersonBalance
    {
        public string ProviderName { get; set; }
        public string ShipCountry { get; set; }
        public int Balance { get; set; }

        public static string[] Countries = { "US", "Spain", "India", "France", "Italy" };
        public static List<Provider> providersList(int number)
        {
            List<Provider> list = new List<Provider>();
            Random rnd = new Random(System.DateTime.Now.Millisecond);
            for (int i = 1; i <= number; i++)
            {
                Provider p = new Provider();
                p.ProviderName = Path.GetRandomFileName().Replace(".", "");
                p.ShipCountry = Countries[rnd.Next(0, 4)];
                p.Balance = rnd.Next(0, 100000);
                list.Add(p);
            }
            return list;
        }
    }
    public interface IPersonBalance
    {
        int Balance { get; set; }
    }
    public class GenericComparer : IComparer<IPersonBalance>  
    {
        public int Compare(IPersonBalance x, IPersonBalance y)
        {
            if (x.Balance < y.Balance) { return -1; }
            else if (x.Balance > y.Balance) return 1;
            else { return 0; }
        }
    }
    public class ManageProviders
    {
        public static void Main()
        {
            List<Provider> providerList = Provider.providersList(25);
            GenericComparer gc = new GenericComparer();
            // Sort now uses our own definition of comparison
            providerList.Sort(gc);
            Console.WriteLine(" List of providers ordered by Balance");
            Console.WriteLine(" " + ("").PadRight(36, '-'));
            foreach (var item in providerList)
            {
                Console.WriteLine(" ProviderName: {0}, S.Country: {1}, \t Balance: {2}",
                    item.ProviderName, item.ShipCountry, item.Balance);
            }
            Console.ReadKey();
        }
    }
}
