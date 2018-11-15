using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Issues
    {
        public Issues()
        {
            InverseMovedTo = new HashSet<Issues>();
            IssueMetrics = new HashSet<IssueMetrics>();
            MergeRequestsClosingIssues = new HashSet<MergeRequestsClosingIssues>();
            Timelogs = new HashSet<Timelogs>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Description { get; set; }
        public int? MilestoneId { get; set; }
        public string State { get; set; }
        public int? Iid { get; set; }
        public int? UpdatedById { get; set; }
        public bool Confidential { get; set; }
        public DateTime? DueDate { get; set; }
        public int? MovedToId { get; set; }
        public int? LockVersion { get; set; }
        public string TitleHtml { get; set; }
        public string DescriptionHtml { get; set; }
        public int? TimeEstimate { get; set; }
        public int? RelativePosition { get; set; }
        public int? CachedMarkdownVersion { get; set; }
        public DateTime? LastEditedAt { get; set; }
        public int? LastEditedById { get; set; }
        public bool? DiscussionLocked { get; set; }
        public DateTime? ClosedAt { get; set; }

        public Users Author { get; set; }
        public Milestones Milestone { get; set; }
        public Issues MovedTo { get; set; }
        public Projects Project { get; set; }
        public Users UpdatedBy { get; set; }
        public ICollection<Issues> InverseMovedTo { get; set; }
        public ICollection<IssueMetrics> IssueMetrics { get; set; }
        public ICollection<MergeRequestsClosingIssues> MergeRequestsClosingIssues { get; set; }
        public ICollection<Timelogs> Timelogs { get; set; }
    }
}
