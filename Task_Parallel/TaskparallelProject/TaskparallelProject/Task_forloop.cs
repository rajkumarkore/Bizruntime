
//using for and  factrory

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskparallelProject
{
    class Task_forloop
    {
        static void Main(string[] args)
        {
            var a1 = Task.Factory.StartNew(() => DosomeworkIn(1, 3000));
            var a2 = Task.Factory.StartNew(() => DosomeworkIn(2, 1200));
            var a3 = Task.Factory.StartNew(() => DosomeworkIn(3, 1500));

            for(var i = 0; i < 10; i++)
            {
                Console.WriteLine("doing some work");
                Thread.Sleep(250);
                Console.WriteLine("i = {0}", i);
            }

            Console.WriteLine("Doing some other work");
           
            Console.ReadLine();

        }
        static void DosomeworkIn(int id, int sleepTime)
        {
            Console.WriteLine("task {0} 1 is begin", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} 1 is end", id);
        }
    }
}
