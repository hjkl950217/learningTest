using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiBuilds
    {
        public CiBuilds()
        {
            CiBuildTraceSections = new HashSet<CiBuildTraceSections>();
            CiJobArtifacts = new HashSet<CiJobArtifacts>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime? FinishedAt { get; set; }
        public string Trace { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public int? RunnerId { get; set; }
        public double? Coverage { get; set; }
        public int? CommitId { get; set; }
        public string Commands { get; set; }
        public string Name { get; set; }
        public string Options { get; set; }
        public bool AllowFailure { get; set; }
        public string Stage { get; set; }
        public int? TriggerRequestId { get; set; }
        public int? StageIdx { get; set; }
        public bool? Tag { get; set; }
        public string Ref { get; set; }
        public int? UserId { get; set; }
        public string Type { get; set; }
        public string TargetUrl { get; set; }
        public string Description { get; set; }
        public string ArtifactsFile { get; set; }
        public int? ProjectId { get; set; }
        public string ArtifactsMetadata { get; set; }
        public int? ErasedById { get; set; }
        public DateTime? ErasedAt { get; set; }
        public DateTime? ArtifactsExpireAt { get; set; }
        public string Environment { get; set; }
        public long? ArtifactsSize { get; set; }
        public string When { get; set; }
        public string YamlVariables { get; set; }
        public DateTime? QueuedAt { get; set; }
        public string Token { get; set; }
        public int? LockVersion { get; set; }
        public string CoverageRegex { get; set; }
        public int? AutoCanceledById { get; set; }
        public bool? Retried { get; set; }
        public int? StageId { get; set; }
        public bool? Protected { get; set; }
        public int? FailureReason { get; set; }

        public CiPipelines AutoCanceledBy { get; set; }
        public Projects Project { get; set; }
        public CiStages StageNavigation { get; set; }
        public ICollection<CiBuildTraceSections> CiBuildTraceSections { get; set; }
        public ICollection<CiJobArtifacts> CiJobArtifacts { get; set; }
    }
}
