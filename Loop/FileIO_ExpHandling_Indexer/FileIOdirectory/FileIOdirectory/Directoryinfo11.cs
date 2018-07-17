using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace FileIOdirectory
{
    class Directoryinfo1
    {
        static void Main(string[] args)
        {
            //DirectoryInfo currDir = new DirectoryInfo(".");////to access currnt dirctory

            Directoryinfo di = new Directoryinfo(".");
            Directoryinfo dereksDir = new Directoryinfo(@"D:\b\loop");
            
                
                //DirectoryInfo dereksDir = new DirectoryInfo(@"D:\BizRunTime\File i.o_Exp_Handling");

            Console.WriteLine(dereksDir.FullName);
            Console.WriteLine(dereksDir.Name);
            Console.WriteLine(dereksDir.Parent);
            Console.WriteLine(dereksDir.Attributes);
            Console.WriteLine(dereksDir.CreationTime);
        

            Console.ReadLine(); 

         

        }
    }
}


/*
 D:\BizRunTime\File i.o_Exp_Handling
File i.o_Exp_Handling
BizRunTime
Directory
09-07-2018 09:17:04 AM
    
 */
