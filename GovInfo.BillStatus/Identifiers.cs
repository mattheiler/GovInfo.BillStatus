using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Identifiers
    {
        [XmlElement("lisID")]
        public string LisId { get; set; }

        [XmlElement("bioguideId")]
        public string BioguideId { get; set; }

        [XmlElement("gpoId")]
        public string GpoId { get; set; }
    }
}