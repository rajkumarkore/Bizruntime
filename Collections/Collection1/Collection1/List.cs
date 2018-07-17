using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class List
    {
        public bool Compare(int a,int b)
        {
            // if (a == b) //if equal return t else false

            if (a.Equals(b))
                return true;
            return false;
        }

        static void Main()
        {
            List obj = new List();
            bool result = obj.Compare(10, 10);
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
