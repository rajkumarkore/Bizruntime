using System;
using System.IO;
namespace FileIOdirectory
{
    class BinaryReadWrite
    {
        static void Main(string[] args)
        {
            BinaryReader br;
            BinaryWriter bw;

            int i = 25;
            double d = 3.141;
            bool b = true;
            string s = "i am happy";

            //here file creating 

            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));

            }catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n cannot create file.");
                return;
            }

            //writing  into the file

            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n cannot write to file.");
                return;
            }
            bw.Close();

            //reading frm the file

            try
            {
                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
            }catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n  cannot open file.");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Int data: {0}", i);
                d = br.ReadDouble();
               
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.Read();
        }
    }
}


/*
 
Int data: 25
Double data: 3.141
Boolean data: True
String data: i am happy


     */
