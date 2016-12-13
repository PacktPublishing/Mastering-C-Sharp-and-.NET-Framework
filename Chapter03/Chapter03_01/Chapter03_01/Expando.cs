using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Chapter04_01
{
    class Expando
    {
        static void Main(string[] args)
        {
            // Expando objects allow dynamic creation of properties
            //dynamic oex = new ExpandoObject();
            //oex.integerProp = 7;
            //oex.stringProp = "And this is the string property";
            //oex.datetimeProp = new ExpandoObject();
            //oex.datetimeProp.dayOfWeek = DateTime.Today.DayOfWeek;
            //oex.datetimeProp.time = DateTime.Now.TimeOfDay;

            //Console.WriteLine("Int: {0}", oex.integerProp);
            //Console.WriteLine("String: {0}", oex.stringProp);
            //Console.WriteLine("Day of Week: {0}", oex.datetimeProp.dayOfWeek);
            //Console.WriteLine("Time: {0}", oex.datetimeProp.time);

            //Console.ReadLine();

            var listOfBooks = new List<dynamic>();
            var book1 = CreateBookObject("Mastering C# and .NET Programming", 500);
            var book2 = CreateBookObject("Practical Machine Learning", 468);
            listOfBooks.Add(book1);
            listOfBooks.Add(book2);
            var bookWith500Pages = listOfBooks.Find(b => b.Pages == 500);
            Console.WriteLine("Packt Pub. Books with 500 pages: {0}", 
                bookWith500Pages.Title);
            Console.ReadLine();
        }
        public static dynamic CreateBookObject(dynamic title, dynamic pages)
        {
            dynamic book = new ExpandoObject();
            book.Title = title;
            book.Pages = pages;
            return book;
        }
    }
}
