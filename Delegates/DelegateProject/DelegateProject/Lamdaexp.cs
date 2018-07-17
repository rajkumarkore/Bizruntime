using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public delegate string Greetings(string str);
    class Lamdaexp
    {
        static void Main()
        {
            Greetings g = (name) =>
            {
                return "Hello " + name + " a well good ";
            };

            string str = g.Invoke("om ");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}

//Hello om  a well good

