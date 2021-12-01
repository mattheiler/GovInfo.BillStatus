using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Law
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("number")]
        public string Number { get; set; }
    }
}