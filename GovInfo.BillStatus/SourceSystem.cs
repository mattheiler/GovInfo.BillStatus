using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class SourceSystem
    {
        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
    }
}