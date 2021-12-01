using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class PolicyArea
    {
        [XmlElement("name")]
        public string Name { get; set; }
    }
}