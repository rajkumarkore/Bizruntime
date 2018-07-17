
//exption nothing but runtime error

using System;

using System.IO;

namespace FileIOdirectory
{
    class Extrycatch
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c; //here 3 varibales
                Console.WriteLine("Enter two Number:");
                a = Convert.ToInt32(Console.ReadLine()); //here we have to pass a value it is a int type when compiling 
                                                         //it will trete as string typ then we convetr string to int type we can us two ToInt32 or Parse()methd
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;

                Console.WriteLine("Quotient is :" + c);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);//display expn error

            }
            finally
            {
                Console.WriteLine("code is executed");
            }
            Console.Read();
        }

    }
}





