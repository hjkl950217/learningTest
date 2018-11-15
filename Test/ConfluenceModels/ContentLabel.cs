using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class ContentLabel
    {
        public decimal Id { get; set; }
        public decimal Labelid { get; set; }
        public decimal? Contentid { get; set; }
        public decimal? Attachmentid { get; set; }
        public decimal? Pagetemplateid { get; set; }
        public string Owner { get; set; }
        public DateTime? Creationdate { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public decimal? Labelableid { get; set; }
        public string Labelabletype { get; set; }

        public AttachmentsBackup Attachment { get; set; }
        public Content Content { get; set; }
        public Label Label { get; set; }
        public UserMapping OwnerNavigation { get; set; }
        public Pagetemplates Pagetemplate { get; set; }
    }
}
