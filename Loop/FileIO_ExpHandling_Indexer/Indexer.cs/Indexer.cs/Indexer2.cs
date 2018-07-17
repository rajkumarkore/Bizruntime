using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.cs
{
    class Indexer2
    {
         class Program
         {
             private string[] names = new string[6];
             public  string this[int i]
             {
                 get
                 {
                     return names[i];

                 }
                 set
                 {
                     names[i] = value;
                 }

             }
         }

         static void Main(string[] args)
         {
             Program Team = new Program();
             Team[0] = "R";
             Team[1] = "s";
             Team[2] = "t";
             Team[3] = "u";
             Team[4] = "v";
             Team[5] = "w";

             for(int i = 0; i < 6; i++)
             {
                 Console.WriteLine(Team[i]);
             }
             Console.ReadKey();
         }
     }
 }