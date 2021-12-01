using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class RelatedBill
    {
        [XmlElement("number")]
        public int Number { get; set; }

        [XmlElement("latestAction")]
        public LatestAction LatestAction { get; set; }

        [XmlElement("latestTitle")]
        public string LatestTitle { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("congress")]
        public int Congress { get; set; }

        [XmlArray("relationshipDetails")]
        [XmlArrayItem("item")]
        public List<RelationshipDetails> Details { get; set; }
    }
}