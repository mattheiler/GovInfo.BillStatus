using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class LegislativeSubject
    {
        [XmlElement("name")]
        public string Name { get; set; }
    }
}