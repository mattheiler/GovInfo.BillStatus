using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Bill
    {
        [XmlElement("billType")]
        public string Type { get; set; }

        [XmlElement("billNumber")]
        public int Number { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("congress")]
        public int Congress { get; set; }

        [XmlElement("originChamber")]
        public string Origin { get; set; }

        [XmlElement("introducedDate")]
        public string Introduced { get; set; }

        [XmlElement("createDate")]
        public string Created { get; set; }

        [XmlElement("updateDate")]
        public string Updated { get; set; }

        [XmlElement("constitutionalAuthorityStatementText")]
        public string ConstitutionalAuthorityStatement { get; set; }

        [XmlElement("policyArea")]
        public PolicyArea PolicyArea { get; set; }

        [XmlElement("subjects")]
        public Subjects Subjects { get; set; }

        [XmlElement("summaries")]
        public Summaries Summaries { get; set; }

        [XmlElement("committees")]
        public Committees Committees { get; set; }

        [XmlArray("cboCostEstimates")]
        [XmlArrayItem("item")]
        public List<CostEstimate> CostEstimates { get; set; }

        [XmlArray("laws")]
        [XmlArrayItem("item")]
        public List<Law> Laws { get; set; }

        [XmlArray("recordedVotes")]
        [XmlArrayItem("recordedVote")]
        public List<RecordedVote> RecordedVotes { get; set; }

        [XmlArray("notes")]
        [XmlArrayItem("item")]
        public List<Note> Notes { get; set; }

        [XmlArray("titles")]
        [XmlArrayItem("item")]
        public List<Title> Titles { get; set; }

        [XmlArray("actions")]
        [XmlArrayItem("item")]
        public List<Action> Actions { get; set; }

        [XmlArray("relatedBills")]
        [XmlArrayItem("item")]
        public List<RelatedBill> RelatedBills { get; set; }

        [XmlArray("calendarNumbers")]
        [XmlArrayItem("item")]
        public List<CalendarNumber> CalendarNumbers { get; set; }

        [XmlArray("committeeReports")]
        [XmlArrayItem("committeeReport")]
        public List<CommitteeReport> CommitteeReports { get; set; }

        [XmlArray("cosponsors")]
        [XmlArrayItem("item")]
        public List<Cosponsor> Cosponsors { get; set; }

        [XmlArray("sponsors")]
        [XmlArrayItem("item")]
        public List<Sponsor> Sponsors { get; set; }

        [XmlArray("amendments")]
        [XmlArrayItem("amendment")]
        public List<Amendment> Amendments { get; set; }

        [XmlArray("textVersions")]
        [XmlArrayItem("item")]
        public List<TextVersion> TestVersions { get; set; }
    }
}