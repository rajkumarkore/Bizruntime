using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Demo1
    {
        void print();

    }
    interface Demo2
    {
        void print();

    }


    class Program : Demo1, Demo2
    {
        void Demo1.print()
        {
            Console.WriteLine("Debendra");
        }
        void Demo2.print()
        {
            Console.WriteLine("Debendra");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ((Demo2)p).print();
            Console.ReadLine();

        }
    }
}

