using Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Datos
{
    public class XmlStringDeserializer
    {
        public XmlString Deserialize(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XmlString));
            StringReader reader = new StringReader(xml);
            return (XmlString)serializer.Deserialize(reader);
        }
    }
}
