using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ur name:");
            string name = Console.ReadLine();

            Console.WriteLine("enter name : " + name);
            Console.WriteLine("enter ur age is : " + age);
        }
    }
}
