using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
namespace Serialization
{
    [DataContract]
    class Jsonex
    {
        [DataMember]
        public int id;
        [DataMember]
        public string name;
        [DataMember]
        public string place;
        public Jsonex(int id, string name, string place)
        {
            this.id = id;
            this.name = name;
            this.place = place;
        }
        static void Main(string[] args)
        {
            Jsonex e1 = new Jsonex(1, "kumar", "hubli");
            FileStream stream = new FileStream(@"D:\BizRuntime\Jsonex.json", FileMode.OpenOrCreate);
            //serializes the object to JSON          
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Jsonex));
            //DataContractJsonSerializer class helps to serialize and deserialize JSON
            ser.WriteObject(stream, e1);
            StreamReader sr = new StreamReader(stream);
            string str = sr.ReadToEnd();
            Console.WriteLine("serializes the object to JSON done");
            Console.ReadKey();
        }
    }
}