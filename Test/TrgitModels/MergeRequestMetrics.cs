using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class MergeRequestMetrics
    {
        public int Id { get; set; }
        public int MergeRequestId { get; set; }
        public DateTime? LatestBuildStartedAt { get; set; }
        public DateTime? LatestBuildFinishedAt { get; set; }
        public DateTime? FirstDeployedToProductionAt { get; set; }
        public DateTime? MergedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? PipelineId { get; set; }
        public int? MergedById { get; set; }
        public int? LatestClosedById { get; set; }
        public DateTime? LatestClosedAt { get; set; }

        public Users LatestClosedBy { get; set; }
        public MergeRequests MergeRequest { get; set; }
        public Users MergedBy { get; set; }
        public CiPipelines Pipeline { get; set; }
    }
}
