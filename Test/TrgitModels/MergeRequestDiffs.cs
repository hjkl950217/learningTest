using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class MergeRequestDiffs
    {
        public MergeRequestDiffs()
        {
            MergeRequests = new HashSet<MergeRequests>();
        }

        public int Id { get; set; }
        public string State { get; set; }
        public int MergeRequestId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string BaseCommitSha { get; set; }
        public string RealSize { get; set; }
        public string HeadCommitSha { get; set; }
        public string StartCommitSha { get; set; }
        public int? CommitsCount { get; set; }

        public MergeRequests MergeRequest { get; set; }
        public ICollection<MergeRequests> MergeRequests { get; set; }
    }
}
