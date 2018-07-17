using System;

namespace Inheritance
{
    class Overloading
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public float Add(float x , float y)
        {
            return x + y;
        }
        public int Add(int x , int y, int z)
        {
            return x + y + z;
        }
    }
    class ClsOverload
    {
        static void Main(string[] args)
        {
            Overloading obj1 = new Overloading();
            Console.WriteLine("sum is :" + obj1.Add(10, 20));
            Console.WriteLine("sum is : " + obj1.Add(12.5F, 40));
            Console.WriteLine("sum is : " + obj1.Add(10, 20, 30));
            Console.Read();
         }
    }
}

/*
 out put
 sum is :30
sum is : 52.5
sum is : 60   
 */
