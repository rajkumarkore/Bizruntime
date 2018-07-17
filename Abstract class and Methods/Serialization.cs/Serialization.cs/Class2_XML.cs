using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Serialization.cs
{
    class Class2_XML
    {
        static void Main(string[] args)
        {
            classXML c = new classXML();
            c.Age = 22;
            c.Male = true;
            c.Name = "sai";
            
            Console.WriteLine(c.Age);
            Console.WriteLine(c.Male);
            Console.WriteLine(c.Name);
            Console.ReadLine();
        }
    }
}
