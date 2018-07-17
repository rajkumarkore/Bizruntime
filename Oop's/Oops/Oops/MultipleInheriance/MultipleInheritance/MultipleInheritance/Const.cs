using System;

namespace MultipleInheritance
{
    class Const
    {
        public int x = 100;
    }
    class TestClasses
    {
        static void Main(string[] args)
        {
            Const f1 = new Const();
            Const f2 = new Const();
            Console.WriteLine(f1.x + " " + f2.x);
            Console.ReadLine();

        }
    }
 }

