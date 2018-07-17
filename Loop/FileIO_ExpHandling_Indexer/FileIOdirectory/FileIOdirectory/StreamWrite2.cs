using System;
using System.IO;

namespace FileIOdirectory
{
    class StreamWrite2
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "om", "sai" };

            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}



//om
//sai