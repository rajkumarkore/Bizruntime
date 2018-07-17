using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Sortmethod
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 2, 3, 4, 6, 7 };
            int[] C = new int[6] { 2, 3, 4, 6, 7,8 };

            Console.WriteLine("elemnets of arry A are");
            foreach(int i in A)
            {
                Console.WriteLine(i + " ");
             }

            Console.WriteLine("elemnets of arry C are");
            foreach (int i in C)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
