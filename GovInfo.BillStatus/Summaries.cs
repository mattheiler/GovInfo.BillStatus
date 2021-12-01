using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Summaries
    {
        [XmlArray("billSummaries")]
        [XmlArrayItem("item")]
        public List<BillSummary> BillSummaries { get; set; }
    }
}