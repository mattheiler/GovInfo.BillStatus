using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Subjects
    {
        [XmlElement("billSubjects")]
        public BillSubjects BillSubjects { get; set; }
    }
}