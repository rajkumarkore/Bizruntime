using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    class Readbyte
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\b.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
            Console.Read();
        }
    }
}
