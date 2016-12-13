using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace NETCoreConsoleApp1
{
    public class Program
    {
        static string pathImages = @"C:\Users\Marino\Desktop\PACKT\_CH13 (Advanced)\DemosCH\NETCoreConsoleApp1\src\NETCoreConsoleApp1\bin\Debug\netcoreapp1.0";
        static void Main(string[] args)
        {
            Console.WriteLine(" Largest number of Rows: " + Console.LargestWindowHeight);
            Console.WriteLine(" Largest number of Columns: " + Console.LargestWindowWidth);
            Console.WriteLine(" ------------------------------\n");
            ReadFiles(pathImages);
            Console.ReadLine();
        }
        private static void ReadFiles(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            var files = di.EnumerateFiles("*.txt",
                SearchOption.TopDirectoryOnly).ToArray();
            foreach (var item in files)
            {
                Console.WriteLine(" "+ File.ReadAllText(item.FullName));
            }
        }

    }
}
