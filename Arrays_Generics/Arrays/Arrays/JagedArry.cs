using System;

namespace Arrays
{
    class JagedArry
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            A[0] = new int[4] { 1, 2, 3 ,4};
            A[1] = new int[3] { 1, 2,3};
            A[2] = new int[2] { 1, 2 };

            Console.WriteLine("Elements of jagged arry are:");
            

            foreach(int[] r in A)
            {
                foreach(int c in r)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("lenth is: " + A.Length);
            Console.WriteLine("Rank is : " + A.Rank);
            Console.Read();
        }
    }
}


/*
 * 
 Elements of jagged arry are:
1 2 3 4
1 2 3
1 2

 */






