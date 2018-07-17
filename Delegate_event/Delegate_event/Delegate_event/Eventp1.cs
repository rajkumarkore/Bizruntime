using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_event
{
    public delegate void DelegateE();

    class Eventp1
    {  
         public static event DelegateE del;  //Event Handlers can't return a value. They are always void.

        static void Main(string[] args)
        {
            del += new DelegateE(India);  //the delegate invocation lists with a couple of defined methods using the +=operator as well
            del += new DelegateE(USA);  
            del += new DelegateE(UK);
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

