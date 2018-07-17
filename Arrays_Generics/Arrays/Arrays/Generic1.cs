using System;

namespace Arrays
{     

    class Generic2<G2, G1>
    {
        public void Display(G2 s1, G1 s2)
        {
            Console.WriteLine("value of s1 and s2 are  : {0}, {1}", s1, s2);
        }
        class Generic1
        { 
        static void Main(string[] args)
            {
                Generic2<string, int> obj1 = new Generic2<string,int>();
                Generic2<double, int> obj2 = new Generic2<double, int>();
                Generic2<string, double> obj3 = new Generic2<string, double>();

                obj1.Display("om",10);
                obj2.Display(22.3,22);
                obj3.Display("sai",20.3);
                Console.Read();
            }



           
        }
    }
}
