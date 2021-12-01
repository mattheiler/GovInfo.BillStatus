using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class ActionTypeCounts
    {
        [XmlElement("amendmentProposed")]
        public int AmendmentProposed { get; set; }

        [XmlElement("amendmentAgreedTo")]
        public int AmendmentAgreedTo { get; set; }

        [XmlElement("senateAmendmentAgreedTo")]
        public int SenateAmendmentAgreedTo { get; set; }

        [XmlElement("senateAmendmentSubmitted")]
        public int SenateAmendmentSubmitted { get; set; }

        [XmlElement("senateAmendmentProposedOnTheFloor")]
        public int SenateAmendmentProposedOnTheFloor { get; set; }
    }
}