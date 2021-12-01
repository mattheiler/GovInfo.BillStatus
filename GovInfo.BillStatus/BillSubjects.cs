using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class BillSubjects
    {
        [XmlArray("legislativeSubjects")]
        [XmlArrayItem("item")]
        public List<LegislativeSubject> LegislativeSubjects { get; set; }

        [XmlElement("policyArea")]
        public PolicyArea PolicyArea { get; set; }
    }
}