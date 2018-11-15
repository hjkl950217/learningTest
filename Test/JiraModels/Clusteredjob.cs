using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Clusteredjob
    {
        public decimal Id { get; set; }
        public string JobId { get; set; }
        public string JobRunnerKey { get; set; }
        public string SchedType { get; set; }
        public decimal? IntervalMillis { get; set; }
        public decimal? FirstRun { get; set; }
        public string CronExpression { get; set; }
        public string TimeZone { get; set; }
        public decimal? NextRun { get; set; }
        public decimal? Version { get; set; }
        public byte[] Parameters { get; set; }
    }
}
