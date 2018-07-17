using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskparallelProject
{
    class Task_for
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 6, 7, 8, 9 };
           
            //for(int i = 0;i < 10; i++)

            Parallel.For(0, 10, i =>    //we can do parallel also usng parallel
            {
                Console.WriteLine("i = " + i);
                Thread.Sleep(1000);
            });
        }
    }
}


//multiple task we can to parallely