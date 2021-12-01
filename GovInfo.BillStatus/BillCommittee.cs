using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class BillCommittee
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("systemCode")]
        public string SystemCode { get; set; }

        [XmlArray("subcommittees")]
        [XmlArrayItem("item")]
        public List<Subcommittee> Subcommittees { get; set; }

        [XmlArray("activities")]
        [XmlArrayItem("item")]
        public List<Activity> Activities { get; set; }
    }
}