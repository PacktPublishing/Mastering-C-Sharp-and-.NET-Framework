using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface ITarget
    {
        List<string> GetCars();
    }
    public class ListOfCarsProvider
    {
        public List<string> GetListOfCars()
        {
            List<string> carsList = new List<string>();
            carsList.Add("Ferrari");
            carsList.Add("Mercedes");
            carsList.Add("BMW");
            carsList.Add("Ford");
            return carsList;
        }
    }
    class VendorAdapter : ITarget
    {
        public List<string> GetCars()
        {
            ListOfCarsProvider adaptee = new ListOfCarsProvider();
            return adaptee.GetListOfCars();
        }
    }
    class ShoppingCarsPortal
    {
        static void Main(string[] args)
        {
            Console.Title = "Demo of the Adapter Pattern";
            ITarget adapter = new VendorAdapter();
            foreach (string brand in adapter.GetCars())
            {
                Console.WriteLine("Brand: " + brand);
            }
            Console.ReadLine();
        }
    }


}
