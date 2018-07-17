using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
   public class classXML

    {
        public int Age { get; set;}
        [XmlAttribute]
        public bool Male { get;  set; }
        [XmlAttribute]
        public string Name { get; set; }
     
        public void Save (string fileName)
        {
            using (var stream = new FileStream(@"D:\BizRunTime\abc.xml", FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(classXML));
                XML.Serialize(stream, this);
            }

        }
    }
}
