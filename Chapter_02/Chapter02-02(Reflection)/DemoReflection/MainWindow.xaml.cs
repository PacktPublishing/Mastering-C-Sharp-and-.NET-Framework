using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace DemoReflection
{
    public partial class MainWindow : Window
    {
        static short counter = 0;
        static List<int> numberList;
        static List<int> divisibleNumbers = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            numberList = Enumerable.Range(1, 100).ToList();
            ClassicDelegateMethod();
            PrintResults("Numbers divisible by 2 and 3");
        }

        private void btnLaunch_Click(object sender, RoutedEventArgs e)
        {
            // Establish a reference to this window 
            Type windowType = this.GetType();
            // Creates an instance of the Window 
            object objWindow = Activator.CreateInstance(windowType);
            // cast to a MainWindow type
            MainWindow aWindow = (MainWindow)objWindow;
            aWindow.Title = "Reflected Window No: " + (++counter).ToString();
            aWindow.Show();
        }

        private void CheckMod2(int x)
        {
            if (x % 2 == 0) divisibleNumbers.Add(x);
        }
        private void CheckMod3(int x)
        {
            if (x % 3 == 0) divisibleNumbers.Add(x);
        }
        delegate void DivisibleBy(int number);
        private void ClassicDelegateMethod()
        {
            DivisibleBy ed = new DivisibleBy(CheckMod2);
            // Invocation of several methods (Multicasting)
            ed += CheckMod3;
            // Every call to ed generates a multicast sequence
            foreach (int x in numberList) { ed(x); }
        }

        private void PrintResults(string header)
        {
            lbSelected.Items.Add(header);
            lbSelected.Items.Add("".PadRight(header.Length, '-'));
            foreach (var item in divisibleNumbers)
            {
                lbSelected.Items.Add($"Selected: {item}");
            }
            Console.Read();
        }

    }
}
