using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Chapter03_03
{
    public class ExpressionBodied
    {
        public static void Main()
        {
            ExpressionBodied eb = new ExpressionBodied();
            WriteLine(eb.ToString());
            Read();

            Dictionary<int, string> HttpWebErrors = new Dictionary<int, string>
            {
                [301] = "The page requested has been permanently moved",
                [307] = "The requested resource is available only through a proxy",
                [403] = "Access forbiden by the server",
                [404] = "Page not found. Try to change the URL",
                [408] = "Request timeout. Try again."
            };


        }
        public string Name { get; } = "Chris";
        public string LastName { get; } = "Talline";
        public override string ToString() => $"FullName: {LastName}, {Name}";
        public bool FullNameFits => ((Name.Length + LastName.Length) > 12) ? false : true;
    }
}
