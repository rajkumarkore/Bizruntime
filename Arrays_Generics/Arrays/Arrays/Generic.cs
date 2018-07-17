using System;

namespace Arrays
{
    class Generic
    {
        static void Display<G>(G s) //here g is gclass ,,s is a parameter vale
        {
            Console.WriteLine("value of s is :" + s );

        }
        static void Main(string[] args)
        {
            Display<int>(10);
            Display<string>("hello");
            Display<double>(20.3);
            Console.Read();

        }
    }
}


/*
 value of s is :10
value of s is :hello
value of s is :20.3


    //length is for no .of elements  and rank is for dimentions
 */
