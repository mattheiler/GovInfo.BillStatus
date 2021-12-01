using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class AmendedAmendment
    {
        [XmlElement("number")]
        public int Number { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("purpose")]
        public string Purpose { get; set; }

        [XmlElement("congress")]
        public int Congress { get; set; }
    }
}