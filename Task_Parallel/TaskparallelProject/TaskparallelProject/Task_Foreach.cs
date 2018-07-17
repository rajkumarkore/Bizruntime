using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskparallelProject
{
    class Task_Foreach
    {
        static void Main(string[] args)
        {
            var intList = new List<int> { 1, 2, 3, 4, 5, 55, 6, 77 };

            // Parallel.ForEach(intList, (i => Console.WriteLine(i)));

            Parallel.For(0,100, (i) => Console.WriteLine(i));
            Console.WriteLine("press any key to quit");
            Console.ReadKey();
        }
    }
}
