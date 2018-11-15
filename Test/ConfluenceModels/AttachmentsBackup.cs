using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class AttachmentsBackup
    {
        public AttachmentsBackup()
        {
            ContentLabel = new HashSet<ContentLabel>();
            InversePrevverNavigation = new HashSet<AttachmentsBackup>();
        }

        public decimal Attachmentid { get; set; }
        public string Title { get; set; }
        public string Contenttype { get; set; }
        public decimal Pageid { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public decimal? Filesize { get; set; }
        public byte? MinorEdit { get; set; }
        public string AttachmentComment { get; set; }
        public int? Attversion { get; set; }
        public decimal? Prevver { get; set; }

        public AttachmentsBackup PrevverNavigation { get; set; }
        public ICollection<ContentLabel> ContentLabel { get; set; }
        public ICollection<AttachmentsBackup> InversePrevverNavigation { get; set; }
    }
}
