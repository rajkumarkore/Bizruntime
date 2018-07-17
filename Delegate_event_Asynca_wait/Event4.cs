using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_event
{
    public delegate void DelegateB();

    class Event4
    {
        public static event DelegateB del;  

        static void Main(string[] args)
        {
            del += new DelegateB(India); 
            del += new DelegateB(USA);
            del += new DelegateB(UK);
            del.Invoke();
            Console.ReadLine();
        }

        static void India()
        {
            Console.WriteLine("india");
        }

        static void USA()
        {
            Console.WriteLine("usa");
        }
        static void UK()
        {
            Console.WriteLine("uk");
        }
    }
}


    