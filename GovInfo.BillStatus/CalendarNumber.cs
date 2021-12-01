using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class CalendarNumber
    {
        [XmlElement("calendar")]
        public string Calendar { get; set; }

        [XmlElement("number")]
        public string Number { get; set; }
    }
}