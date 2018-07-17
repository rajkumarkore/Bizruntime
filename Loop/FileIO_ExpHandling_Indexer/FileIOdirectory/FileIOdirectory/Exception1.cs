using System;

namespace FileIOdirectory
{
    class Exception1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("secn no nt 0");
            }
            else
            {
                c = a / b;
                Console.WriteLine("Quotient is:" + c);
            }
                Console.Read();

            
        }
    }
}

//expn hnadling by using logincal impln

/*
 Enter two numbers:
50
0
secn no nt 0

 */
