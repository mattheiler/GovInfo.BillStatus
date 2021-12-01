using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class BillSummary
    {
        [XmlElement("versionCode")]
        public string VersionCode { get; set; }

        [XmlElement("actionDate")]
        public string ActionDate { get; set; }

        [XmlElement("actionDesc")]
        public string ActionDescription { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("lastSummaryUpdateDate")]
        public string LastUpdated { get; set; }

        [XmlElement("updateDate")]
        public string Updated { get; set; }

        [XmlElement("text")]
        public string Text { get; set; }
    }
}