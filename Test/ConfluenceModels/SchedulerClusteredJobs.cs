using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class SchedulerClusteredJobs
    {
        public decimal Id { get; set; }
        public string JobId { get; set; }
        public DateTime? NextRunTime { get; set; }
        public decimal? Version { get; set; }
        public string JobRunnerKey { get; set; }
        public byte[] RawParameters { get; set; }
        public string SchedType { get; set; }
        public string CronExpression { get; set; }
        public string CronTimeZone { get; set; }
        public DateTime? IntervalFirstRunTime { get; set; }
        public decimal? IntervalMillis { get; set; }
    }
}
