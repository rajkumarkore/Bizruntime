using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Checked
    {
        static void Main(string[] args)
        {
            //checked
            unchecked  //-2147483647

            {
                int val = int.MaxValue;
                Console.WriteLine(val); //System.OverflowException: 'Arithmetic operation resulted in an overflow.'
                Console.Read();
            }
        }
    }
}

/*
//when use checke:

The checked keyword is used to explicitly check overflow and conversion of
integral type values at compile time.
ex:

//System.OverflowException: 'Arithmetic operation resulted in an overflow.'

//unchecked

The Unchecked keyword ignores the integral type arithmetic exceptions.
It does not check explicitly and produce result that may be truncated or wrong.
ex:
//-2147483647

 */












