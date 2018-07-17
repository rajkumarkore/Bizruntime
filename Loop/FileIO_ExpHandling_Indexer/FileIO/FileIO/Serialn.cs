using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace FileIO
{
    class Serialn
    {
       
        int rollno;
        string name;
        public Serialn(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class SerializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("e:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Serialn s = new Serialn(101, "sonoo");
            formatter.Serialize(stream, s);

            stream.Close();
            Console.Read();
        }
    }
}

