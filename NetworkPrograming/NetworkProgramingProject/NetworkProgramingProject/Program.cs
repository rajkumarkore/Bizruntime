
//tcp client pgm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace NetworkProgramingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plz eneter the  server name");
            string server = Console.ReadLine();
            TcpClient client = new TcpClient(server, 80); //here 80 is a web port server
            StreamReader sr = new StreamReader(client.GetStream());//to establish connectio need read and write stream
            StreamWriter sw = new StreamWriter(client.GetStream());

            try
            {             //expn types--->  IO,ObjectDisposedException,EncoderFallbackException

                sw.WriteLine("Get / HTTP/1.0\n\n"); //requesting to web page
                sw.Flush(); //clears all buffuers to the current writer causes any bufferd to written to underlyinh

                string data = sr.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
                client.Close();
            }catch(Exception e)
            { 
            }

            Console.ReadLine();

        }
    }
}
