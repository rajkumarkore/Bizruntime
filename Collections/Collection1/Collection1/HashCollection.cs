using System;
using System.Collections;

namespace Collection1
{
    class HashCollection
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();//fetching data faster bcz of hash code
            ht.Add("A", 12);
            ht.Add("B", 2.3);
            ht.Add("C", 3);
            ht.Add("Email", "asd@gmail.com");
            ht.Add("Cell", 55.1);

            //Console.WriteLine("Hello".GetHashCode());

            foreach (object key in ht.Keys)
                Console.WriteLine(key + ":" + ht[key]);
            Console.ReadLine();
        }
    }
    }

/*
 //hash table internally generate hashcode value and store it
 //hash table contanint key,value and hashcode
 //here key,value  is object and hashcode is a integer it ll always sote inegert
 //every class by default having 4 mthd 
1.gethashcode
2.equals
4.gettype
3.tostring
 
 -694847
C
Cell
Email
A
B

    after this
    Console.WriteLine(key + ":" + ht[key]);
    //both key and values
    C:3
Cell:55.1
Email:asd@gmail.com
A:12
B:2.3
     
     */


