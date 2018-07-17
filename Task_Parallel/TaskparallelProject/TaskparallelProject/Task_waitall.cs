
// using WaitAll
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskparallelProject
{
    class Task_waitall
    {
        static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() => Dosomework(1, 3000));  //WaitAll
            var t2 = Task.Factory.StartNew(() => Dosomework(2, 2000));
            var t3 = Task.Factory.StartNew(() => Dosomework(3, 1000));

            var tasklist = new List<Task> { t1, t2, t3 };

            Task.WaitAll(tasklist.ToArray());

            Console.WriteLine("press any key to continue");
            Console.ReadLine();
        }

        static void Dosomework(int id , int sleepTime)
        {
            Console.WriteLine("task {0} begin 1 ", id);
            Thread.Sleep(sleepTime);

        }
    }
}
