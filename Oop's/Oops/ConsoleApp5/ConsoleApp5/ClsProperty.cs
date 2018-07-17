using System;

namespace ConsoleApp5
{
    class ClsProperty
    {
        static void Main(string[] args)
        {

            ClsEmployee2 obj2 = new ClsEmployee2();
            Console.WriteLine("enter Emp Details: ");
            obj2.PEmpId = Convert.ToInt32(Console.ReadLine());
            obj2.PEName = Console.ReadLine();
            obj2.PEAddress = Console.ReadLine();
            obj2.PEAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Emp Details are : ");
            Console.WriteLine("EmpID is :" + obj2.PEmpId);
            Console.WriteLine("EName is :" + obj2.PEName);
            Console.WriteLine("EAddress is:" + obj2.PEAddress);
            Console.WriteLine("EAge is : " + obj2.PEAge);

            Console.Read();
        }

    }
}
