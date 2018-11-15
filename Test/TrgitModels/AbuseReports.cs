using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class AbuseReports
    {
        public int Id { get; set; }
        public int? ReporterId { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string MessageHtml { get; set; }
        public int? CachedMarkdownVersion { get; set; }
    }
}
