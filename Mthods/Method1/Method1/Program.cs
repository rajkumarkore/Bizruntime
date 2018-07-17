using System; //this is a base class lib

namespace Method1
{
    class Program
    {
        public int FindMax(int num1, int num2)
        { /*local variable deln*/

            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
          }

        static void Main(string[] args)
        {/*local variable definition*/

            int a = 100;
            int b = 200;
            int ret;
            Program n = new Program();

            //calling the Progm methd

            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
        }
        }
  }

