using System;
using System.Collections;

namespace Collection1
{
    class Hash3
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("2", "e");
            ht.Add("f", 4);

            foreach (object key in ht.Keys)
                Console.WriteLine(key + ": " + ht[key]);
            Console.ReadLine();

                    
        }
    }
}
