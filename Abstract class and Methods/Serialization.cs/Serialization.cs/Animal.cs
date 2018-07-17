using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SerializationExample
{
    [Serializable]
    class Animal
    {
       public int sno;
        public string sname;
        public string address;
        public Animal(int no,string name,string saddress)
        {
            sno = no;
            sname = name;
            address = saddress;
        }
    }
}
