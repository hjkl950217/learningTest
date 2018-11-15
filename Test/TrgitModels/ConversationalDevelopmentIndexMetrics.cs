using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ConversationalDevelopmentIndexMetrics
    {
        public int Id { get; set; }
        public double LeaderIssues { get; set; }
        public double InstanceIssues { get; set; }
        public double LeaderNotes { get; set; }
        public double InstanceNotes { get; set; }
        public double LeaderMilestones { get; set; }
        public double InstanceMilestones { get; set; }
        public double LeaderBoards { get; set; }
        public double InstanceBoards { get; set; }
        public double LeaderMergeRequests { get; set; }
        public double InstanceMergeRequests { get; set; }
        public double LeaderCiPipelines { get; set; }
        public double InstanceCiPipelines { get; set; }
        public double LeaderEnvironments { get; set; }
        public double InstanceEnvironments { get; set; }
        public double LeaderDeployments { get; set; }
        public double InstanceDeployments { get; set; }
        public double LeaderProjectsPrometheusActive { get; set; }
        public double InstanceProjectsPrometheusActive { get; set; }
        public double LeaderServiceDeskIssues { get; set; }
        public double InstanceServiceDeskIssues { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public double PercentageBoards { get; set; }
        public double PercentageCiPipelines { get; set; }
        public double PercentageDeployments { get; set; }
        public double PercentageEnvironments { get; set; }
        public double PercentageIssues { get; set; }
        public double PercentageMergeRequests { get; set; }
        public double PercentageMilestones { get; set; }
        public double PercentageNotes { get; set; }
        public double PercentageProjectsPrometheusActive { get; set; }
        public double PercentageServiceDeskIssues { get; set; }
    }
}
