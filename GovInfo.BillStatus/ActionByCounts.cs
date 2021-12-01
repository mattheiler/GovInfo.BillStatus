using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class ActionByCounts
    {
        [XmlElement("houseOfRepresentatives")]
        public int HouseOfRepresentatives { get; set; }

        [XmlElement("senate")]
        public int Senate { get; set; }
    }
}