using System;

namespace Indexer.cs
{
    class Finallyblock
    {
        static void Main(string[] args)
        {
           try
            {
                int a = 9;
                int b = 0;
                int c = a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("done");
            }
            Console.WriteLine("remaing disp");
            Console.Read();
        }
        
    }
}


/*
System.DivideByZeroException: Attempted to divide by zero.
   at Indexer.cs.Finallyblock.Main(String[] args) in D:\BizRunTime\FileIO_ExpHandling_Indexer\Indexer.cs\Indexer.cs\Finallyblock.cs:line 13
finally display
remaing disp

 */
