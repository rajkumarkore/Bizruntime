using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Nullexp
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            array[0] = 1;
            array[1] = 2;
            Test(array);

            array = null;
            Test(array);
        }
        static void Test(int[] array)
        {
            if (array == null)
            {
               
            }
            int rank = array.Rank;
            Console.WriteLine(rank);
            Console.WriteLine(rank);

            Console.Read();      
                   
        }
    }
}
