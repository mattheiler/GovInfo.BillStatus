using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Actions
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlElement("actionTypeCounts")]
        public ActionTypeCounts ActionTypeCounts { get; set; }

        [XmlArray("actions")]
        [XmlArrayItem("item")]
        public List<Action> Items { get; set; }
    }
}