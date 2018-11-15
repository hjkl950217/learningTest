using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class NotificationSettings
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? SourceId { get; set; }
        public string SourceType { get; set; }
        public int Level { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? NewNote { get; set; }
        public bool? NewIssue { get; set; }
        public bool? ReopenIssue { get; set; }
        public bool? CloseIssue { get; set; }
        public bool? ReassignIssue { get; set; }
        public bool? NewMergeRequest { get; set; }
        public bool? ReopenMergeRequest { get; set; }
        public bool? CloseMergeRequest { get; set; }
        public bool? ReassignMergeRequest { get; set; }
        public bool? MergeMergeRequest { get; set; }
        public bool? FailedPipeline { get; set; }
        public bool? SuccessPipeline { get; set; }
    }
}
