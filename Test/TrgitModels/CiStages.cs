using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiStages
    {
        public CiStages()
        {
            CiBuilds = new HashSet<CiBuilds>();
        }

        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? PipelineId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }
        public int? LockVersion { get; set; }

        public CiPipelines Pipeline { get; set; }
        public Projects Project { get; set; }
        public ICollection<CiBuilds> CiBuilds { get; set; }
    }
}
