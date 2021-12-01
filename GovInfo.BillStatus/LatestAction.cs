using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class LatestAction
    {
        [XmlElement("text")]
        public string Text { get; set; }

        [XmlElement("actionDate")]
        public string ActionDate { get; set; }

        [XmlElement("actionTime")]
        public string ActionTime { get; set; }
    }
}