using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class RecordedVote
    {
        [XmlElement("fullActionName")]
        public string FullActionName { get; set; }

        [XmlElement("rollNumber")]
        public int RollNumber { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("sessionNumber")]
        public int SessionNumber { get; set; }

        [XmlElement("chamber")]
        public string Chamber { get; set; }

        [XmlElement("congress")]
        public int Congress { get; set; }

        [XmlElement("date")]
        public string Date { get; set; }
    }
}