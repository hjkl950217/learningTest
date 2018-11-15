using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class IssueMetrics
    {
        public int Id { get; set; }
        public int IssueId { get; set; }
        public DateTime? FirstMentionedInCommitAt { get; set; }
        public DateTime? FirstAssociatedWithMilestoneAt { get; set; }
        public DateTime? FirstAddedToBoardAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Issues Issue { get; set; }
    }
}
