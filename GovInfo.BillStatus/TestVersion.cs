using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class TestVersion
    {
        [XmlElement("date")]
        public string Date { get; set; }

        [XmlArray("formats")]
        [XmlArrayItem("item")]
        public List<TestVersionFormat> Formats { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }
    }
}