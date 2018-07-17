using System;
using System.Collections.Generic;


namespace ConsoleApplication2
{
    delegate string delegatsus<T1, T2>(T1 a, T2 b);
    class Generic2
    {
        static string addnum(int a, int b)
        {
            return (a + b).ToString();

        }
        static string addfloat(double m, double n)
        {

            return (m + n).ToString();

        }
        static string addstring(string s1, string s2)
        {
            return (s1 + s2);

        }
        public static void Main()
        {
            // create delagte instance  
            delegatsus<int, int> getinterger = new delegatsus<int, int>(addnum);
            //getinterger(30, 40);  
            Console.WriteLine(getinterger(3, 3));
            delegatsus<double, double> getfloat = new delegatsus<double, double>(addfloat);
            Console.WriteLine(getfloat(5.5, 7.5));
            delegatsus<string, string> getstring = new delegatsus<string, string>(addstring);
            Console.WriteLine(getstring("hello", "frnd"));
            Console.ReadKey();
        }

    }
} 