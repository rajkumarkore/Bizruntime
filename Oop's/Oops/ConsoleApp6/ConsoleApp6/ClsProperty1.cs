using System;

namespace ConsoleApp6
{
    class ClsProperty1
    {
        static void Main(string[] args)
        {
            ClsProperty1 obj1 = new ClsProperty1();
            Console.WriteLine("Enter two numbers:");
            obj1.PNum1 = Convert.ToInt32(Console.ReadLine());
            obj1.PNum2 = Convert.ToInt32(Console.ReadLine());

            obj1.Add();
            Console.WriteLine("difference is :" + obj1.PResult);

        }
    }
}
