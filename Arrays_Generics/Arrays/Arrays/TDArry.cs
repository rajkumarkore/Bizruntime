using System;


namespace Arrays
{
    class TDArry
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("elemnets of Arry are:");
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(A[r, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nlenth is: " + A.Length);   //length is for no .of elements  and rank is for dimentions
            Console.WriteLine("\nRank is : " + A.Rank);
            Console.Read();
        }
    }
}


/*
 elemnets of Arry are:
1 2 3
4 5 6
7 8 9

lenth is: 9

Rank is : 2

     */
