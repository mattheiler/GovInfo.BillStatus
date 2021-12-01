using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class CommitteeReport
    {
        [XmlElement("citation")]
        public string Citation { get; set; }
    }
}