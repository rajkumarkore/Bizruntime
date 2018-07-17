using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DelegateProject
{
    class Async
    {       
            static void Main()
            {
                Task task = new Task(CallMethod);
                task.Start();
                task.Wait();
                //nsole.ReadLine();
            }

            static async void CallMethod()
            {
                string filePath ="D:\\BizRunTime\\Delegates\\DelegateProject\\DelegateProject\\bin\\Debug\\sampleFile.txt";
                Task<int> task = ReadFile(filePath);

                Console.WriteLine(" Other Work 1");
                Console.WriteLine(" Other Work 2");
                Console.WriteLine(" Other Work 3");

                int length = await task;
                Console.WriteLine(" Total length: " + length);

                Console.WriteLine(" After work 1");
                Console.WriteLine(" After work 2");
            }

            static async Task<int> ReadFile(string file)
            {
                int length = 0;

                Console.WriteLine(" File reading is stating");
                using (StreamReader reader = new StreamReader(file))
                {
                    // Reads all characters from the current position to the end of the stream asynchronously  
                    // and returns them as one string.  
                    string s = await reader.ReadToEndAsync();

                    length = s.Length;
                }
                Console.WriteLine(" File reading is completed");
                return length;
            }
        }
    }




/*
 
    File reading is stating
 Other Work 1
 Other Work 2
 Other Work 3
 File reading is completed
 Total length: 0
 After work 1
 After work 2





 */



















