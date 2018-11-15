using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Replicatedindexoperation
    {
        public decimal Id { get; set; }
        public DateTime? IndexTime { get; set; }
        public string NodeId { get; set; }
        public string AffectedIndex { get; set; }
        public string EntityType { get; set; }
        public string AffectedIds { get; set; }
        public string Operation { get; set; }
        public string Filename { get; set; }
    }
}
