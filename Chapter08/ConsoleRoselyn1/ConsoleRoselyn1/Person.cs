using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleRoselyn1
{
    class Person
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        internal Person Create()
        {
            Person p = new Person();
            p.id = 1;
            p.Name = "Chris Talline";
            p.Age = 33;
            return p;
        }
        internal string PersonData()
        {
            var p = Create();
            return p.id.ToString() + "-" + p.Name + "-" + 
                   p.Age.ToString();
        }
    }
}
