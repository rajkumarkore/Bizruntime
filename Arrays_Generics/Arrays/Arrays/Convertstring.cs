using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Convertstring
    {
        static void Main(string[] args)
        {
            //String s = "100";  // 100 then 100
            String s = null;   //0 thne Expn
            Console.WriteLine(Convert.ToInt32(s));//it will convert null value ..0
            Console.WriteLine(int.Parse(s)); //it will nt covert int.Parse() to null it ll  give ArgumentNullException
            Console.Read();
        }
    }
}


//to convert string to int type ues these----- Console.WriteLine(Convert.ToInt32(s))
//to convert string to int type ues these-----  Console.WriteLine(int.Parse(s));
//it will convert null value ..0
//it will nt covert int.Parse() to null it ll  give ArgumentNullException