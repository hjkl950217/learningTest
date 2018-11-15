using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiPipelines
    {
        public CiPipelines()
        {
            CiBuilds = new HashSet<CiBuilds>();
            CiPipelineVariables = new HashSet<CiPipelineVariables>();
            CiStages = new HashSet<CiStages>();
            InverseAutoCanceledBy = new HashSet<CiPipelines>();
            MergeRequestMetrics = new HashSet<MergeRequestMetrics>();
            MergeRequests = new HashSet<MergeRequests>();
        }

        public int Id { get; set; }
        public string Ref { get; set; }
        public string Sha { get; set; }
        public string BeforeSha { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? Tag { get; set; }
        public string YamlErrors { get; set; }
        public DateTime? CommittedAt { get; set; }
        public int? ProjectId { get; set; }
        public string Status { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public int? Duration { get; set; }
        public int? UserId { get; set; }
        public int? LockVersion { get; set; }
        public int? AutoCanceledById { get; set; }
        public int? PipelineScheduleId { get; set; }
        public int? Source { get; set; }
        public bool? Protected { get; set; }
        public int? ConfigSource { get; set; }
        public int? FailureReason { get; set; }

        public CiPipelines AutoCanceledBy { get; set; }
        public CiPipelineSchedules PipelineSchedule { get; set; }
        public Projects Project { get; set; }
        public ICollection<CiBuilds> CiBuilds { get; set; }
        public ICollection<CiPipelineVariables> CiPipelineVariables { get; set; }
        public ICollection<CiStages> CiStages { get; set; }
        public ICollection<CiPipelines> InverseAutoCanceledBy { get; set; }
        public ICollection<MergeRequestMetrics> MergeRequestMetrics { get; set; }
        public ICollection<MergeRequests> MergeRequests { get; set; }
    }
}
