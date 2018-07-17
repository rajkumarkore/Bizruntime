using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 
namespace TaskparallelProject
{
    class Task1
    {
        static void Main(string[] args)
        {
            var t1 = new Task(() => {
                Console.WriteLine("task 1 is begin");
                Thread.Sleep(2000);
                Console.WriteLine("task 1 is end ");
            });
            t1.Start();
            Console.WriteLine(  "any key press to continue");
            Console.ReadLine();
        }
    }
}
