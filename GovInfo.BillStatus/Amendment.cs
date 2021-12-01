using System.Collections.Generic;
using System.Xml.Serialization;

namespace GovInfo.BillStatus
{
    public class Amendment
    {
        [XmlElement("number")]
        public int Number { get; set; }

        [XmlElement("congress")]
        public int Congress { get; set; }

        [XmlElement("chamber")]
        public string Chamber { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("purpose")]
        public string Purpose { get; set; }

        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("submittedDate")]
        public string SubmittedDate { get; set; }

        [XmlElement("proposedDate")]
        public string ProposedDate { get; set; }

        [XmlElement("createDate")]
        public string CreateDate { get; set; }

        [XmlElement("updateDate")]
        public string UpdateDate { get; set; }

        [XmlArray("sponsors")]
        [XmlArrayItem("item")]
        public List<Sponsor> Sponsors { get; set; }

        [XmlArray("cosponsors")]
        [XmlArrayItem("item")]
        public List<Cosponsor> Cosponsors { get; set; }

        [XmlElement("actions")]
        public Actions Actions { get; set; }

        [XmlArray("links")]
        [XmlArrayItem("link")]
        public List<Link> Links { get; set; }

        [XmlArray("notes")]
        [XmlArrayItem("note")]
        public List<Note> Notes { get; set; }

        [XmlElement("amendedAmendment")]
        public AmendedAmendment AmendedAmendment { get; set; }

        [XmlElement("amendedBill")]
        public AmendedBill AmendedBill { get; set; }

        [XmlElement("latestAction")]
        public LatestAction LatestAction { get; set; }
    }
}