using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Convertint
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the two numbers:");
            a = Convert.ToInt32(Console.ReadLine());  //here TOInt32 --it will take upto 9 digits
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("sum is :" + c);
            Console.Read();
        }
    }
}

/*
 //
    //here TOInt16 --it will take upto 4 digits
    //here TOInt32 --it will take upto 9 digits
    //here TOInt64 --it will take upto 9 digits

 enter the two numbers:
25
35
sum is :60

Press any key to continue . . .
*/
























