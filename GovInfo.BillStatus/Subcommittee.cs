using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Subcommittee
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("systemCode")]
        public string SystemCode { get; set; }

        [XmlArray("activities")]
        [XmlArrayItem("item")]
        public List<Activity> Activities { get; set; }
    }
}