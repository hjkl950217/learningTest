using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class WebHooks
    {
        public WebHooks()
        {
            WebHookLogs = new HashSet<WebHookLogs>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Type { get; set; }
        public int? ServiceId { get; set; }
        public bool? PushEvents { get; set; }
        public bool IssuesEvents { get; set; }
        public bool MergeRequestsEvents { get; set; }
        public bool? TagPushEvents { get; set; }
        public bool NoteEvents { get; set; }
        public bool? EnableSslVerification { get; set; }
        public bool WikiPageEvents { get; set; }
        public string Token { get; set; }
        public bool PipelineEvents { get; set; }
        public bool ConfidentialIssuesEvents { get; set; }
        public bool RepositoryUpdateEvents { get; set; }
        public bool JobEvents { get; set; }

        public Projects Project { get; set; }
        public ICollection<WebHookLogs> WebHookLogs { get; set; }
    }
}
