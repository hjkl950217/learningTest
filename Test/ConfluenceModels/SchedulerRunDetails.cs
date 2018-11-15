using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class SchedulerRunDetails
    {
        public decimal Id { get; set; }
        public string JobId { get; set; }
        public DateTime? StartTime { get; set; }
        public decimal? Duration { get; set; }
        public string Outcome { get; set; }
        public string Message { get; set; }
    }
}
