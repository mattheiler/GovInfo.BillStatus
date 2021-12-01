using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class AmendedBill
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("congress")]
        public int Congress { get; set; }

        [XmlElement("number")]
        public int Number { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("originChamberCode")]
        public string OriginChamberCode { get; set; }

        [XmlElement("originChamber")]
        public string OriginChamber { get; set; }
    }
}