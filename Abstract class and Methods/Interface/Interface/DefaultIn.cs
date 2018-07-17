using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface  A
    {
        void Method();
    }

    interface B
    {
        void Method();
    }
    public class DefaultIn : A , B
    {
        public void Method()
        {
            Console.WriteLine("om");
        }
          void B.Method()
        {
            Console.WriteLine("sai");
        }

          public static void Main()
        {
            DefaultIn p = new DefaultIn();
            p.Method();
            ((B)p).Method();

            Console.ReadLine();
        }
    }
}
