using System;

namespace InterfaceExamples
{
    interface I1
    {
        void IntefaceMethod();
    }
    interface I2
    {
        void IntefaceMethod();
    }

    public class ExplicitInterfaceImplementation : I1,I2
        {
            void I1.IntefaceMethod()
            {
                Console.WriteLine("I1 print");
            }
            void I2.IntefaceMethod()
             {
                 Console.WriteLine("I2 print");
           }
        public static void Main()
        {
            ExplicitInterfaceImplementation p = new ExplicitInterfaceImplementation();
            ((I1)p).IntefaceMethod();
            ((I2)p).IntefaceMethod();
            Console.ReadLine();
        }
    }
 }



/*
 
I1 print
I2 print
    
 */























