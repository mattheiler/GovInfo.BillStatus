using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class CostEstimate
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("pubDate")]
        public string PublicationDate { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }
    }
}