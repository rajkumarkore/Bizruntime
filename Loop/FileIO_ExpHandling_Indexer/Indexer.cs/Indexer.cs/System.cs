using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class System
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[10];
                arr[6] = 10;
            }
            catch(SystemException e)
            {
                Console.WriteLine(e);
                Console.Read();
            }
            
        }
    }
}
