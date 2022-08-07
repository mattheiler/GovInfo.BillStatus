using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Action
    {
        [XmlElement("actionCode")]
        public string Code { get; set; }

        [XmlElement("actionDate")]
        public string Date { get; set; }

        [XmlElement("actionTime")]
        public string Time { get; set; }

        [XmlElement("sourceSystem")]
        public SourceSystem SourceSystem { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("text")]
        public string Text { get; set; }

        [XmlArray("committees")]
        [XmlArrayItem("item")]
        public List<Committee> Committees { get; set; }

        [XmlArray("links")]
        [XmlArrayItem("link")]
        public List<Link> Links { get; set; }
    }
}