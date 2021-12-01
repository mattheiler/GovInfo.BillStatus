using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Committees
    {
        [XmlArray("billCommittees")]
        [XmlArrayItem("item")]
        public List<BillCommittee> BillCommittees { get; set; }
    }
}