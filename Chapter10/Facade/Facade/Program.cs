using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade f = new Facade();
            f.CollectData();
        }
    }
    class Facade
    {
        internal string CollectData()
        {
            A a = new A();
            B b = new B();
            return a.MethodA() + b.MethodC() + " + " + b.MethodD();
        }
    }
    class A
    {
        internal string MethodA()
        {
            return "dataA + " + MethodB();
        }
        string MethodB()
        {
            return "dataB";
        }

    }
    class B
    {
        internal string MethodC()
        {
            return "dataC";
        }
        internal string MethodD()
        {
            return "dataD";
        }
    }

}
