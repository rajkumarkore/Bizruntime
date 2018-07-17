using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIOdirectory
{
    class FilerRW
    {
       // static void WriteFile(string FileName)
        
        static void WriteFile(string FileName)
        {
            //file.writealltext(filename, "hello world"

            File.WriteAllText(FileName, "hello world");
            
        }

        static void ReadFile(string FileName)
        {
            Console.WriteLine(File.ReadAllText(FileName));
        }
        static void Main(string[] args)
        {
            string Filename = @"D:\BizRunTime\File i.o_Exp_Handling\h.txt";
            WriteFile(Filename);

            ReadFile(Filename);
            Console.Read()
        }

    }
}
