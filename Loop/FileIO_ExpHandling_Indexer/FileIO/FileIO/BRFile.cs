using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class BRFile
    {
        static void Main(string[] args)
        {
            
        WriteBinaryFile();
        ReadBinaryFile();
        Console.ReadKey();
            }
        static void WriteBinaryFile()
       {
        using (BinaryWriter w = new BinaryWriter(File.Open("e:\\binaryfile.dat", FileMode.Create)))
        {
            w.Write(12.5);
            w.Write("this is string data");
            w.Write(true);
        }
        }
    static void ReadBinaryFile()
    {
        using (BinaryReader reader = new BinaryReader(File.Open("e:\\binaryfile.dat", FileMode.Open)))
        {
            Console.WriteLine("Double Value : " + reader.ReadDouble());
            Console.WriteLine("String Value : " + reader.ReadString());
            Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
        }
    }
}  
}  



    

