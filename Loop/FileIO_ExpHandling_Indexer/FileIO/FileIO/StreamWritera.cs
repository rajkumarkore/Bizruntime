using System;
using System.IO;

namespace FileIO
{
    class StreamWritera
    {
        static void Main(string[] args)
        {
            WriteForFile();
            ReadForFile();
        }
        public static void WriteForFile()
        {
            StreamWriter s = new StreamWriter(@"D:\\BizRunTime\\sr.txt");
            s.WriteLine("hello world");
            s.Close();
        }

        public static void ReadForFile()
        {
            StreamReader r = new StreamReader(@"D:\\BizRunTime\\sr.txt");
            Console.WriteLine(r.ReadToEnd());
            r.Close();
            Console.Read();
        }
    }
}
