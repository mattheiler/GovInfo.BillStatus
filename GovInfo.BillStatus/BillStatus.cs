using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    [XmlRoot("billStatus")]
    public class BillStatus
    {
        [XmlElement("bill")]
        public Bill Bill { get; set; }
    }
}