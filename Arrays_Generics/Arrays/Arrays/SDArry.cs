using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class SDArry
    {
        static void Main(string[] args)
        {
            int[] A = new int[4] { 10, 20, 30, 40 };

            //String[] A = new string[4] { "a", "b", "c" , "d"};
            Console.WriteLine("Elements of array:");
            /*for (int i = 0; i < 4; i++)
            {
                Console.Write(A[i] + " ");
            } */

            foreach(int i in A) //if i use here int type it will nt conver stg type
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("lenth is: " + A.Length);
            Console.WriteLine("Rank is : " + A.Rank);
            Console.Read();
        }
    }
}

/*
 Elements of array:
10 20 30 40 lenth is: 4
Rank is : 1

    */

//foreach() loop -> if i use here int type it will nt convert  stg type
//foreach() loop ->  if i use here string  type it will nt convert  int type

//for loop ll read index maner
//foreach() loop it will read by value  maner nt index maneer

