using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskparallelProject
{
    class Task_Continiuewith
    {
        static void Main(string[] args)
        {
            var v1 = Task.Factory.StartNew(() => Dosomework(1, 2000));
            var v2 = Task.Factory.StartNew(() => Dosomework(2, 2000));
            var v3 = Task.Factory.StartNew(() => Dosomework(3, 2000));

            Console.WriteLine("");
            Console.ReadLine();
        }

        static void Dosomework(int id , int SleepTime)
        {
            Console.WriteLine("task {0} is begin",id);
            Thread.Sleep(SleepTime);
            Console.WriteLine("task {0} is end", id);
        }

       
    }
}
