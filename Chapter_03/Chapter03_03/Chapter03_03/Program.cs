using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Chapter03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //var data = ReadFileData();
            //Console.WriteLine(data);
            //StringInterpolation();
            C.GetString();
        }

        private static object ReadFileData()
        {
            var info = "";
            var yesterday = DateTime.Today.Day - 1;
            try
            {
                var sr = File.ReadAllText("TextFile.txt");
                info = sr;
            }
            catch when (File.ReadAllText("TextFile.txt") ==
                    DateTime.Now.Minute.ToString())
            {
                info = "File not updated";
            }
            return info;
        }

        #region "String interpolation"
        private static void StringInterpolation()
        {
            string filename = "TextFile.txt";
            try
            {
                Console.WriteLine($"File contents: {File.ReadAllText(filename)}");
                Console.ReadLine();
            }
            catch when (File.Exists(filename) &&
                        DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("File content unreadable on saturdays");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"I/O Exception generated:{ex.Message}");
            }

        }
        #endregion

        [DebuggerDisplay("={" + nameof(GetString) + "()}")]
        public class C
        {
            public static string GetString()
            {
                //int? x = 8;
                //x.HasValue; // == true if x != null

                // case 1
                //string str = null;
                //Console.WriteLine(str ?? "Unspecified");
                //Console.WriteLine($"str value: { str ?? "Unspecified"}");

                Console.ReadLine();
                // Case 2
                string str = null;
                string str2 = "string";
                Console.WriteLine(str ?? "Unspecified");
                Console.WriteLine(str2 ?? "Unspecified");
                Console.WriteLine($"str value: { str ?? "Unspecified"}");
                Console.WriteLine($"str2 value: { str2 ?? "Unspecified"}");
                Console.WriteLine($"str Length: {str?.Length}");
                Console.WriteLine($"str2 Length: {str2?.Length}");
                Console.ReadLine();

                return "";
            }

        }


    }
}
