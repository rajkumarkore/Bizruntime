using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class DynamicAaary
    {
        static void Main(string[] args)
        {
            int[] A = new int[4] { 1, 2, 3, 4 };
            Console.WriteLine("elemnets of arry are :");
            foreach(int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n enter new size of Arry:");
            int N = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref A, N);
            Console.WriteLine("\nelements of arrya after resize are :");
            foreach(int i in A)
            {
                Console.Write(i + " ");

            }
                
            Console.Read();
        }
    }
}

/*
 
 elemnets of arry are :
1 2 3 4
 enter new size of Arry:
2

elements of arrya after resize are :
1 2
    
      
     
elemnets of arry are :
1 2 3 4
 enter new size of Arry:
9

elements of arrya after resize are :
1 2 3 4 0 0 0 0 0


     */

//here  array is a class Resize()  is a method
//we can change arry size dynamically are clearly with help of  resize() mtd