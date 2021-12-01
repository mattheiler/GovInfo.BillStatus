using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Title
    {
        [XmlElement("title")]
        public string Text { get; set; }

        [XmlElement("titleType")]
        public string Type { get; set; }

        [XmlElement("chamberName")]
        public string ChamberName { get; set; }

        [XmlElement("chamberCode")]
        public string ChamberCode { get; set; }

        [XmlElement("parentTitleType")]
        public string ParentType { get; set; }
    }
}