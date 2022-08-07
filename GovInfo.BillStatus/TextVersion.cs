using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class TextVersion
    {
        [XmlElement("date")]
        public string Date { get; set; }

        [XmlArray("formats")]
        [XmlArrayItem("item")]
        public List<TextVersionFormat> Formats { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }
    }
}