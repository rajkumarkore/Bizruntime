using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class GenericList<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a; //
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

        public void Sub(T a, T b)
        {
            dynamic d1 = a; //
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
    }
    class TestGeneric
    {
        static void Main(string[] args)
        {
            GenericList<int> obj = new GenericList<int>();
            obj.Add(10, 20);obj.Sub(10, 20);
            Console.ReadLine();
        }
    }
}


//dynamic is keyword which is introduced in 4.0
// var is identifies in compl time and
//dynamic identifies at run time
