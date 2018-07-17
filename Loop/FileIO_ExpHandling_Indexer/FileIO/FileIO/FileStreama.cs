using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    class FileStreama
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\BizRunTime\\b.txt", FileMode.OpenOrCreate);
            f.WriteByte(68);//this values will change the digits
            f.Close();
            Console.WriteLine();
            Console.Read();
        }
    }
}
