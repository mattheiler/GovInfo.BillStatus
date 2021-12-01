using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class RelationshipDetails
    {
        [XmlElement("identifiedBy")]
        public string IdentifiedBy { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }
    }
}