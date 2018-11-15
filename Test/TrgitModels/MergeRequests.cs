using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class MergeRequests
    {
        public MergeRequests()
        {
            MergeRequestDiffs = new HashSet<MergeRequestDiffs>();
            MergeRequestMetrics = new HashSet<MergeRequestMetrics>();
            MergeRequestsClosingIssues = new HashSet<MergeRequestsClosingIssues>();
            Timelogs = new HashSet<Timelogs>();
        }

        public int Id { get; set; }
        public string TargetBranch { get; set; }
        public string SourceBranch { get; set; }
        public int? SourceProjectId { get; set; }
        public int? AuthorId { get; set; }
        public int? AssigneeId { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? MilestoneId { get; set; }
        public string State { get; set; }
        public string MergeStatus { get; set; }
        public int TargetProjectId { get; set; }
        public int? Iid { get; set; }
        public string Description { get; set; }
        public int? UpdatedById { get; set; }
        public string MergeError { get; set; }
        public string MergeParams { get; set; }
        public bool MergeWhenPipelineSucceeds { get; set; }
        public int? MergeUserId { get; set; }
        public string MergeCommitSha { get; set; }
        public string InProgressMergeCommitSha { get; set; }
        public int? LockVersion { get; set; }
        public string TitleHtml { get; set; }
        public string DescriptionHtml { get; set; }
        public int? TimeEstimate { get; set; }
        public int? CachedMarkdownVersion { get; set; }
        public DateTime? LastEditedAt { get; set; }
        public int? LastEditedById { get; set; }
        public int? HeadPipelineId { get; set; }
        public string RebaseCommitSha { get; set; }
        public string MergeJid { get; set; }
        public bool? DiscussionLocked { get; set; }
        public int? LatestMergeRequestDiffId { get; set; }
        public bool? AllowMaintainerToPush { get; set; }

        public Users Assignee { get; set; }
        public Users Author { get; set; }
        public CiPipelines HeadPipeline { get; set; }
        public MergeRequestDiffs LatestMergeRequestDiff { get; set; }
        public Users MergeUser { get; set; }
        public Milestones Milestone { get; set; }
        public Projects SourceProject { get; set; }
        public Projects TargetProject { get; set; }
        public Users UpdatedBy { get; set; }
        public ICollection<MergeRequestDiffs> MergeRequestDiffs { get; set; }
        public ICollection<MergeRequestMetrics> MergeRequestMetrics { get; set; }
        public ICollection<MergeRequestsClosingIssues> MergeRequestsClosingIssues { get; set; }
        public ICollection<Timelogs> Timelogs { get; set; }
    }
}
