using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskparallelProject
{
    class TaskFactory
    {
        static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() => Dosomework(1, 6000));
            var t2 = Task.Factory.StartNew(() => Dosomework(2, 1000));
            var t3 = Task.Factory.StartNew(() => Dosomework(3, 3000));
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }

        static void Dosomework(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is begin", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} is completed", id);
        }
    }
}
