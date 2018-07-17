using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public delegate void my_multi_delegate(int x, int y);

    class MulcastDelegate
    {     
           static void Main(string[] args)
        {
            my_multi_delegate del = new my_multi_delegate(abc.ss); //encapsulate the fun ss with the delegate
            del += new my_multi_delegate(abc.ss1); //adding fun ss1 in the invocation list with the help of += operator
            del += new my_multi_delegate(abc.ss2); //adding fun ss2 in the invocation list
            del(4, 2);

            //now we remove the function ss from the invocation lit with the help of -= operator
            del -= new my_multi_delegate(abc.ss); // Now in the invocation list 2 method namely ss1 and ss2 remains
            Console.WriteLine("");

            Console.WriteLine("After removing first fun ss from the invocation list ");
            del(4, 2);
            //now we remove the function ss2 from the invocation lit with the help of -= operator
                        del -= new my_multi_delegate(abc.ss2); // Now in the invocation list 1 method ss1 remains

            Console.WriteLine("");

            Console.WriteLine("After removing fun ss2 from the invocation list ");

            del(4, 2);

            Console.ReadLine();

        }

    }
    
    class abc
        {
            public static void ss(int a, int b)
            {
               Console.WriteLine("the out put of first method is " + (a + b));
             }
            public static void ss1(int i, int j)
            {
                Console.WriteLine("the out put of second method is " + (i * j));
            }
            public static void ss2(int m, int n)

            {
                Console.WriteLine("the output of 3rd function is " + (m / n));

            }

        }
    }



/*

tout put of first method is 6
the out put of second method is 8
the output of 3rd function is 2

After removing first fun ss from the invocation list
the out put of second method is 8
the output of 3rd function is 2

After removing fun ss2 from the invocation list
the out put of second method is 8
*/




























