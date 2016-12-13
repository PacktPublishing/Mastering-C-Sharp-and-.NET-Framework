using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRoselyn1
{
    class InitialParser
    {
        static void Main(string[] args)
        {
            // Fist, we localize and load the file to check out
            string filename = @"C:\Users\Marino\Desktop\ConsoleRoselyn1\ConsoleRoselyn1\Person.cs";
            string content = File.ReadAllText(filename);
            // Now we have to analyze the contents
            // So, we use the same class as before. Notice 
            // it returns a SyntaxTree object.
            SyntaxTree tree = CSharpSyntaxTree.ParseText(content);



            SyntaxNode root = tree.GetRoot();
            // Gets the class identifier
            ClassDeclarationSyntax personClass = root.DescendantNodes().
                OfType<ClassDeclarationSyntax>().First();
            Console.WriteLine("Class names");
            Console.WriteLine("-----------");
            Console.WriteLine(personClass.Identifier);
            // Now, the methods 
            Console.WriteLine("\nMethod names");
            Console.WriteLine("------------");
            personClass.DescendantNodes().
                OfType<MethodDeclarationSyntax>().ToList().
                ForEach(method => Console.WriteLine(method.Identifier));

            // And the properties
            Console.WriteLine("\nProperties");
            Console.WriteLine("----------");
            personClass.DescendantNodes()
                .OfType<PropertyDeclarationSyntax>().ToList()
                .ForEach(property => Console.WriteLine(property.Identifier));

            Console.Read();
        }
    }
}
