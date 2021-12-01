using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class TestVersionFormat
    {
        [XmlElement("url")]
        public string Url { get; set; }
    }
}