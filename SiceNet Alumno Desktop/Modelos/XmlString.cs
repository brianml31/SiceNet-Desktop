using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelos
{
    [XmlRoot(ElementName = "string", Namespace = "http://tempuri.org/")]
    public class XmlString
    {
        [XmlText]
        public string respuestaJson { get; set; }
    }
}
