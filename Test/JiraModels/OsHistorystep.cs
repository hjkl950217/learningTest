using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class OsHistorystep
    {
        public decimal Id { get; set; }
        public decimal? EntryId { get; set; }
        public int? StepId { get; set; }
        public int? ActionId { get; set; }
        public string Owner { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Status { get; set; }
        public string Caller { get; set; }
    }
}
