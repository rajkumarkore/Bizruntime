using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializationa
{
    [Serializable] //serialise attribute,,a class can be serialized. this class cant be inherited
          
        class Tutorial //class to serialize
    {
            public int ID;
            public String Name;
            static void Main(string[] args)
            {
                Tutorial obj = new Tutorial();
                obj.ID = 1;
                obj.Name = ".Net";

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"D:\BizRunTime\ExampleNew.txt", FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, obj); //We then use the formatter class which is used to serialize or convert the object to a binary format
            stream.Close();

                stream = new FileStream(@"D:\BizRunTime\ExampleNew.txt", FileMode.Open, FileAccess.Read);
                Tutorial objnew = (Tutorial)formatter.Deserialize(stream); //deserialize the object

                Console.WriteLine(objnew.ID);   //write data to console
                Console.WriteLine(objnew.Name);

                Console.ReadKey();
            }
        }
    }



//We then use the formatter class which is used to serialize or convert the object to a binary format
//BinaryFormatter class with defult value






