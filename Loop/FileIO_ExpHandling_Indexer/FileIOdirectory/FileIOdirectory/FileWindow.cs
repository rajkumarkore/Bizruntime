using System;

using System.IO;
namespace FileIOdirectory
{
    class FileWindow
    {
        static void Main(string[] args)
        {
            DirectoryInfo dw = new DirectoryInfo(@"C:/windows");
            FileInfo[] f = dw.GetFiles();

            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
            }

            Console.ReadKey();

        }
    }
}
  

  