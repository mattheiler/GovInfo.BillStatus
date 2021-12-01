using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Note
    {
        [XmlElement("text")]
        public string Text { get; set; }

        [XmlArray("links")]
        [XmlArrayItem("link")]
        public List<Link> Links { get; set; }
    }
}