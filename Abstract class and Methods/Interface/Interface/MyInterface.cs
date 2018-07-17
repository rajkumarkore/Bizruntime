using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface MyInterface
    {
        void myMethod();
    }

    class Myclass : MyInterface
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            m.myMethod();
        }
      public void myMethod()
        {
            Console.WriteLine("wel come to india");
            Console.ReadLine();
        }
    }
}
