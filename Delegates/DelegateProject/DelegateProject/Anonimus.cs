using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public delegate string GreetingsD(string str);
    class Anonimus  // a methd without a name,it contains only method  is called anonymous
    {
       

        static void Main(string[] args)
        {
            // GreetingsD g = new GreetingsD(Greetings);

            GreetingsD g = delegate (string name) //a mthd  without having a body is called anonimus
            {
                return "hi " + name + "a very good ";
            };
            string str = g.Invoke("ram");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}


//lesser typing work ..like public data type nt req...this is advantage
//and in lamda expression no need to use delegate keyword and also parameter list








