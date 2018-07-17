using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delegate_event
{
    public delegate string MyDel(string str);
    class EventProgram
    {
        event MyDel MyEvent;

        public EventProgram()
        {
            this.MyEvent += new MyDel(this.Welcomeuser);
        }

        public string Welcomeuser(string username)
        {
            return "welcome " + username;
        }
        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            string result = obj1.MyEvent("Om sai");
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}


//fist non static then static block-------welcome  then omsai ram