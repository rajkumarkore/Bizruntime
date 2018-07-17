using System;
using System.Collections;
namespace Collection1
{
    class Array2
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            Console.WriteLine(ar.Capacity);
            ar.Add(100);
           

                 foreach (object obj in ar)
                Console.Write(obj + " ");
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
