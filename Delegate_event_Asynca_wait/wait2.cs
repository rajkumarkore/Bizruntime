using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_event
{
    class wait2
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadKey();
        }

        private static async void Method()
        {
            await Task.Run(new Action(Method2));
            Console.WriteLine("New Thread");
        }

        private static void Method2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Method2");
        }
    }
}
