
using System;
using System.Collections;

namespace Collection1
{
    class Hash2
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("f", 4);
            ht.Add("d", 6);
            ht.Add("t", 9.5);
            foreach (object key in ht.Keys)
                Console.WriteLine(key + " : " + ht[key]);
            Console.ReadLine();
        }
                    
    }
}
