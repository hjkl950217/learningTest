using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ClusterProjects
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ClusterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Clusters Cluster { get; set; }
        public Projects Project { get; set; }
    }
}
