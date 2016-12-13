using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string pathImages = @"D:\MEDIA\FOTOS";
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Largest number of Window Rows: " + Console.LargestWindowHeight);
            //Console.WriteLine("Largest number of Window Columns: " + Console.LargestWindowWidth);
            //Console.Read();
            //RunANewTask();
            ReadFiles(pathImages);
            Console.ReadLine();

        }

        private static void ReadFiles(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            var files = di.EnumerateFiles("*.jpg", 
                SearchOption.AllDirectories).ToArray<FileInfo>();
            var filesWoSpaces = RemoveInvalidNames(files);
            //var filesWoSpaces = RemoveInvalidNamesParallel(files);
            foreach (var item in filesWoSpaces)
            {
                Console.WriteLine(item.FullName);
            }
        }

        private static bool CheckFile(string fileName)
        {
            return (fileName.Contains(" ")) ? true : false;
        }
        private static List<FileInfo> RemoveInvalidNames(FileInfo[] files)
        {
            var validNames = new  List<FileInfo>();
            foreach (var item in files)
            {
                if (CheckFile(item.Name)==true) {
                    validNames.Add(item);
                }
            }
            return validNames;
        }
        private static FileInfo[] RemoveInvalidNamesParallel(FileInfo[] files)
        {
            var validNames = new ConcurrentBag<FileInfo>();
            Parallel.ForEach(files, (file) => {
                if (CheckFile(file.Name)==true)
                {
                    validNames.Add(file);
                }
            });
            return validNames.ToArray();
        }

        private static void RunANewTask()
        {
            Task task = Task.Run(() =>
            {
                Console.WriteLine("Task started at: " + DateTime.Now.ToLongTimeString());
                Thread.Sleep(1500);
                Console.WriteLine("Task ended at: " + DateTime.Now.ToLongTimeString());
            });
            Console.WriteLine("Task finished: " + task.IsCompleted);
            task.Wait();  // Blocked until the task finishes
        }
    }
}
