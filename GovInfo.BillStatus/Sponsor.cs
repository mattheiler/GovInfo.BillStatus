using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Sponsor
    {
        [XmlElement("name")]
        public string Name { get; set; } // not standard

        [XmlElement("fullName")]
        public string FullName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("identifiers")]
        public Identifiers Identifiers { get; set; }

        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("middleName")]
        public string MiddleName { get; set; }

        [XmlElement("district")]
        public int District { get; set; }

        [XmlElement("party")]
        public string Party { get; set; }

        [XmlElement("state")]
        public string State { get; set; }

        [XmlElement("byRequestType")]
        public string ByRequestType { get; set; }
    }
}