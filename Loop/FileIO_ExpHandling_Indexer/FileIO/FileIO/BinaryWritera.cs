using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    class BinaryWritera
    {
        static void Main(string[] args)
        {
            string fileName = "D:\\BizRunTime\\binaryfile.dat";
            using (BinaryWriter w = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                w.Write(2.5);
                w.Write("this is string data");
                w.Write(true);
            }
            Console.WriteLine("data success");
            Console.Read();
        }
    }
}
