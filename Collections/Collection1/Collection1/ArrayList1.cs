using System;
using System.Collections;

namespace Collection1
{
    class ArrayList1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();//initial capacity value is by defult is 0...then 4..then it ll double 8 then 16 ....
            Console.WriteLine(al.Capacity);
            al.Add(100); //this is the 1st item 
            Console.WriteLine(al.Capacity); //here it is allocating the items when code is runing
            al.Add(200);al.Add(300);al.Add(400);//these are the 3 item's stored 
            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity); //upto here it ll auto resizing

            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            al.Insert(3, 350);////we can insert value using Insert() mtd
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            //al.Remove(200);
            al.RemoveAt(1); //here particular index we can remove
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}

//arrylist  parametre will take one and hash will take two parameter
//we can insert value using Insert() mtd
//we can remove  value using remove() and also particular remove use removeAt()  mtd
//initial capacity value is by defult is 0...then 4..then it ll double 8 then 16 ....
//if you initial any particular value it ll print same 1st vale then it ll change ..Arry(10).



/*
 0
4
4
8
100 200 300 400 500
100 200 300 350 400 500 //adding th value using Insert(3, 350)


100 200 300 350 400 500
100 300 350 400 500  //here 200 removed using  al.Remove(200);


 */
