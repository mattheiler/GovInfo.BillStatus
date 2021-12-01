using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Committee
    {
        [XmlElement("systemCode")]
        public string SystemCode { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
    }
}