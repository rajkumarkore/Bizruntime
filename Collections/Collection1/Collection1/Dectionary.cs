using System;
using System.Collections.Generic;

namespace Collection1
{
    class Dectionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> ht = new Dictionary<string, object>();
            ht.Add("A", 12);
            ht.Add("B", 2.3); //here key value purpose must use string and actual value purpose use object
            ht.Add("C", 3);
            ht.Add("Email", "asd@gmail.com");
            ht.Add("Cell", 55.1);
            foreach (string key in ht.Keys)
                Console.WriteLine(key + ":" + ht[key]);
            Console.ReadLine();
        }
    }
}

/*
   // class Dectionary will print order wise only but htable  nt order wise
   
A:12
B:2.3
C:3
Email:asd@gmail.com
Cell:55.1

    
 */
