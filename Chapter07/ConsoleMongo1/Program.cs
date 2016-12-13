using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleMongo1
{
    class Program
    {
        static IMongoClient client;
        static IMongoDatabase db;
        static IMongoCollection<Customer> coll;
        static void Main(string[] args)
        {
            client = new MongoClient();
            db = client.GetDatabase("NorthWind");
            coll = db.GetCollection<Customer>("Customers");

            //BasicQuery("USA");
            // CustomerQueryAsync();
            // DeleteCustomerAsync();
            //InsertCustomerAsync();
            //ModifyCustomerAsync();
            BasicQueryByCompany("USA");
            Console.Read();
        }
        async private static void ModifyCustomerAsync()
        {
            var filter = Builders<Customer>.Filter.Eq("CompanyName", "The Z Company");
            var update = Builders<Customer>.Update
                .Set("CompanyName", "ZZZZZ Enterprises");
            var result = await coll.UpdateOneAsync(filter, update);
            BasicQueryByCompany("USA");
        }

        async private static void InsertCustomerAsync()
        {
            Customer newCustomer = new Customer()
            {
                CustomerID = "ZZZZZ",
                CompanyName = "The Z Company",
                ContactName = "Zachary Zabek",
                City = "Zeeland",
                Region = "Michigan",
                Country = "USA"
            };
            await coll.InsertOneAsync(newCustomer);
            BasicQuery("USA");
            Console.Read();
        }

        async private static void DeleteCustomerAsync()
        {
            var CustDel = await coll.FindOneAndDeleteAsync(
                c => c.CustomerID == "CHOPS");
            // List customers from Switzerland to check deletion
            BasicQuery("Switzerland");
        }

        async private static void CustomerQueryAsync()
        {
            var owners = await coll.FindAsync(c =>
                (c.Country == "USA" || c.Country == "UK") && c.ContactTitle == "Owner")
                .Result.ToListAsync();
            string title = "Owners from USA or UK";
            Console.WriteLine(title);
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
            foreach (var c in owners)
            {
                Console.WriteLine($"Name: {c.ContactName}, \t City: {c.City} ");
            }
        }

        private static void BasicQuery(string country)
        {
            var americanCustomers = coll.Find(c => c.Country == country)
                .ToListAsync().Result;
            string title = "Customers from " + country;
            Console.WriteLine(title);
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
            foreach (var c in americanCustomers)
            {
                Console.WriteLine($"Name: {c.ContactName}, \t City: {c.City} ");
            }
        }
        private static void BasicQueryByCompany(string country)
        {
            var americanCustomers = coll.Find(c => c.Country == country)
                .ToListAsync().Result;
            string title = "Customers from " + country + " with Companies";
            Console.WriteLine(title);
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
            foreach (var c in americanCustomers)
            {
                string company = c.CompanyName.PadRight(30).Substring(0,30);
                Console.WriteLine($"Company: {company}, City: {c.City} ");
            }
        }
    }


    public class Customer
    {
        public ObjectId _id { get; set; }
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public object Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }


}
