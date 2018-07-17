using System;
using System.IO;


namespace FileIOdirectory
{
    class StreamReader2
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\BizRunTime\File i.o_Exp_Handling\h.txt"))
                {
                    string line;
                    while ((line=sr.ReadLine()) !=null)
                        {
                        Console.WriteLine(line);
                    }
                }
                }catch(Exception e)
            {
                Console.WriteLine("the file could not be read : ");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();


                }
            }
        }
    

