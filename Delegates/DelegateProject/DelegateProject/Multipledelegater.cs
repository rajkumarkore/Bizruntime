using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public delegate void RectDelegate(double W, double height);
    //public delegate void RectDelegate2(double W, double height);
    class Multipledelegater
    {
        public void GetArea(double W, double height)  //a delegate holds to refernce more then one methd
        {
            Console.WriteLine(W * height);
        }

        public void GetPerimeter(double W, double height) //both parameter and methods matches with delegate then it is muldele
        {
            Console.WriteLine(2 * (W + height));
        }

        static void Main()
        {
            Multipledelegater m = new Multipledelegater();
            //m.GetArea(1.0,2.0);
            //m.GetPerimeter(12.3,52.3);

            RectDelegate r = m.GetArea; //4127
           r += m.GetPerimeter; //we can perform bindg one sigle delegate call both call output
            r.Invoke(12.34, 334.5);
            Console.WriteLine();
            r.Invoke(142.34, 3434.5); // RectDelegate this delegate holding referce of two methods and both method bound of and make it as a single call
            Console.ReadLine();
        }
    }
}

/*4127.73
693.68

488866.73
7153.68

//method is return is non value retu=====
//we can perform bindg one sigle delegate call both call output
        


*/
