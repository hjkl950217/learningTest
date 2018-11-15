using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiPipelineSchedules
    {
        public CiPipelineSchedules()
        {
            CiPipelineScheduleVariables = new HashSet<CiPipelineScheduleVariables>();
            CiPipelines = new HashSet<CiPipelines>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Ref { get; set; }
        public string Cron { get; set; }
        public string CronTimezone { get; set; }
        public DateTime? NextRunAt { get; set; }
        public int? ProjectId { get; set; }
        public int? OwnerId { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Users Owner { get; set; }
        public Projects Project { get; set; }
        public ICollection<CiPipelineScheduleVariables> CiPipelineScheduleVariables { get; set; }
        public ICollection<CiPipelines> CiPipelines { get; set; }
    }
}
