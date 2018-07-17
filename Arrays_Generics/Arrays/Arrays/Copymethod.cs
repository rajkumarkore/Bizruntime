using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Copymethod
    {
        static void Main(string[] args)
        {
            int[] A = new int[3] { 1, 2, 3 };
            int[] B = new int[4] { 11, 22, 33, 44 };
            Console.WriteLine("element of   arry A are  :");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n element of   arry B are  :");
            foreach (int i in B)
            {
                Console.Write(i + " ");
            }

            Array.Copy(A, B, 2);
            Console.WriteLine("\n element of   arry B after copy are  :");
            foreach (int i in B)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
       

        }
    }

/*
 element of   arry A are  :
1 2 3
element of   arry B are  :
11 22 33 44
element of   arry B after copy are  :
1 2 33 44

    */
