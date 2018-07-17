using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskparallelProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Task(() => Dosomework(1, 1500));
            t1.Start();
            var t2 = new Task(() => Dosomework(2, 3000));
            t2.Start();
            var t3 = new Task(() => Dosomework(3, 1000));
            t3.Start();
            Console.WriteLine("press any key to quit");
            Console.ReadLine();
        }

        static void Dosomework(int id,int sleepTime)
        {
            Console.WriteLine("task {0} is beginning", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} is completed", id);
            
        }
    }
 }
