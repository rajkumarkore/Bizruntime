using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DelegateProject
{
    class AsynchAwait
    {
       

        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
        public static void Method()
        {
            Task.Run(new Action(LongTask));
            Console.WriteLine("new thrd");
        }

        public static void LongTask()
        {
            Thread.Sleep(2000);
        }
    }
}
