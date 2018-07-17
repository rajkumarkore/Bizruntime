using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArryMethods
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 1, 2, 3, 4, 5 };
            int[] B = new int[6] { 6, 55, 8, 9, 11, 33 };
            Console.WriteLine("Elements of  arry A are:");
            foreach(int i in A)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine("\nElements of  arry B are:");
            foreach (int i in B)
            {
                Console.Write(i + " ");

            }
            // A.CopyTo(B, 2);
            //Array.Copy(A, B, 3);

            // Array.Sort(B);

            //Array.Sort(B, 2, 3);//if i want particular no. or indx to sort use this

            //Array.Reverse(B);

            Array.Clear(B, 2, 4);//to clear particular index



            Console.WriteLine("\nElements of  arry B after Clear are :");
            foreach (int i in B)
            {
                Console.Write(i + " ");

            }
            Console.Read();
        }
    }
}


/*
 coping:

 Elements of  arry A are:
1 2 3 4 5
Elements of  arry B are:
6 7 8 9 11 33
Elements of  arry B after coping are :
1 2 3 9 11 33
 ============================

sorting:

 Elements of  arry A are:
1 2 3 4 5
Elements of  arry B are:
6 55 8 9 11 33
Elements of  arry B after sorting are :
6 8 9 11 33 55


 //Array.Sort(B, 2, 3);//here 2 is index,,,3 is arry length ,,if i want particular no. or indx to sort use
    Elements of  arry A are:
1 2 3 4 5
Elements of  arry B are:
6 55 8 9 11 33
Elements of  arry B after sorting are :
6 55 8 9 11 33

    //Reverse

Elements of  arry A are:
1 2 3 4 5
Elements of  arry B are:
6 55 8 9 11 33
Elements of  arry B after Reverse are :
33 11 9 8 55 6


Clear:  Array.Clear(B, 2, 4);//to clear particular index
-----

Elements of  arry A are:
1 2 3 4 5
Elements of  arry B are:
6 55 8 9 11 33
Elements of  arry B after Reverse are :
6 55 0 0 0 0

  */





