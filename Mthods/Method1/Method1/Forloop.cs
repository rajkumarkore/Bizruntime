using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Forloop
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                //if (i == 1) break; //it ll print 0 then exit


                if (i == 1) continue;

                Console.WriteLine("values are {0} ", i);
            }
               
              
            }
        }
    }

