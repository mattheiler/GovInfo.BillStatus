using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class TextVersionFormat
    {
        [XmlElement("url")]
        public string Url { get; set; }
    }
}