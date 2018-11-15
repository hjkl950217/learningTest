using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Timelogs
    {
        public int Id { get; set; }
        public int TimeSpent { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? IssueId { get; set; }
        public int? MergeRequestId { get; set; }
        public DateTime? SpentAt { get; set; }

        public Issues Issue { get; set; }
        public MergeRequests MergeRequest { get; set; }
    }
}
