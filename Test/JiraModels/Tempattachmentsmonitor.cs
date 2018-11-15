using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Tempattachmentsmonitor
    {
        public string TemporaryAttachmentId { get; set; }
        public string FormToken { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public decimal? FileSize { get; set; }
        public decimal? CreatedTime { get; set; }
    }
}
