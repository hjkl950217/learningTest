using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Services
    {
        public Services()
        {
            GcpClusters = new HashSet<GcpClusters>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Active { get; set; }
        public string Properties { get; set; }
        public bool? Template { get; set; }
        public bool? PushEvents { get; set; }
        public bool? IssuesEvents { get; set; }
        public bool? MergeRequestsEvents { get; set; }
        public bool? TagPushEvents { get; set; }
        public bool? NoteEvents { get; set; }
        public string Category { get; set; }
        public bool? Default { get; set; }
        public bool? WikiPageEvents { get; set; }
        public bool PipelineEvents { get; set; }
        public bool? ConfidentialIssuesEvents { get; set; }
        public bool? CommitEvents { get; set; }
        public bool JobEvents { get; set; }

        public Projects Project { get; set; }
        public ICollection<GcpClusters> GcpClusters { get; set; }
    }
}
