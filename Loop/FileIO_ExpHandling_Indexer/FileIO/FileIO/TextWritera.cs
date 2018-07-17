using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class TextWritera
    {
        static void Main(string[] args)
        {
            using (TextWriter t = File.CreateText("D:\\fs.txt"))
            {
                t.WriteLine("hi");
                t.WriteLine("hello");
            }
            Console.WriteLine("data writn success....");
            Console.Read();
        }
    }
}