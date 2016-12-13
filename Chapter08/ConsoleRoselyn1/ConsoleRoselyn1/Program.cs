using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRoselyn1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = CSharpSyntaxTree.ParseText(@"
            private class Class1 {
                public int Method() {
                    return 9;
                }
            }
            ",CSharpParseOptions.Default);

        }
    }
}
