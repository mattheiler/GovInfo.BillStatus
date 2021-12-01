using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Activity
    {
        [XmlElement("date")]
        public string Date { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
    }
}