using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.DayOfWeek;
using static System.Console;
using static System.ConsoleColor;
namespace Chapter03_03
{
    class AutoProperties
    {
        public static string User { get; } = Environment.UserName;
        public static string OpSystem { get; } = Environment.OSVersion.VersionString;
        static void Main()
        {
            //Console.WriteLine($"Current {nameof(User)}: {User}");
            //Console.WriteLine($"Version of Windows: {OpSystem}");
            //Console.ReadLine();

            // Static reference of types
            Console.WriteLine($"The square root of 9 is {Sqrt(9)}");
            DayOfWeek today = DateTime.Today.DayOfWeek;
            //ConsoleColor backcolor = ConsoleColor.Blue;
            //ConsoleColor forecolor = ConsoleColor.White;
            //Console.BackgroundColor = backcolor;
            //Console.ForegroundColor = forecolor;
            BackgroundColor = DarkBlue;
            ForegroundColor = White;
            WriteLine($"{nameof(today)} is {today}");
            WriteLine($"Using {nameof(BackgroundColor)} : {BackgroundColor}");
            WriteLine($"Using {nameof(ForegroundColor)} : {ForegroundColor}");
            Read();
        }
    }

}
