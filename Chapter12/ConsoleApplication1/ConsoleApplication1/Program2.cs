using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program2
    {
        static string pathImages = @"D:\MEDIA\FOTOS";
        static void Main(string[] args)
        {
            //BasicMeasure();
            for (int i = 1; i < 9; i++)
            {
                PreciseMeasure(i);
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();
        }
        private static void BasicMeasure()
        {
            var resolution = Stopwatch.IsHighResolution;
            var frequency = Stopwatch.Frequency;
            Console.WriteLine("Stopwatch initial use showing basic properties");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("High resolution: " + resolution);
            Console.WriteLine("Frequency: " + frequency);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            ReadFiles(pathImages);
            timer.Stop();
            Console.WriteLine("Elapsed time: " + timer.Elapsed);

        }

        private static void PreciseMeasure(int step)
        {
            Console.WriteLine("Stopwatch precise measuring (Step " + step +")");
            Console.WriteLine("------------------------------------");
            Int64 nanoSecPerTick = (1000L * 1000L * 1000L) / Stopwatch.Frequency;
            Stopwatch timer = Stopwatch.StartNew();
            ReadFiles(pathImages);
            timer.Stop();
            var milliSec = timer.ElapsedMilliseconds;
            var nanoSec = timer.ElapsedTicks / nanoSecPerTick;
            Console.WriteLine("Elapsed time (standard): " + timer.Elapsed);
            Console.WriteLine("Elapsed time (millisenconds): " + milliSec + "ms");
            Console.WriteLine("Elapsed time (nanoseconds): " + nanoSec + "ns");
        }

        private static void ReadFiles(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            var files = di.EnumerateFiles("*.png", 
                SearchOption.AllDirectories).ToArray<FileInfo>();
            //foreach (var item in files)
            //{
            //    Console.WriteLine(item.FullName);
            //}
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
