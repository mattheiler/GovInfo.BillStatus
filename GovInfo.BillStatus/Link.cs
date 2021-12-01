using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Link
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }
    }
}