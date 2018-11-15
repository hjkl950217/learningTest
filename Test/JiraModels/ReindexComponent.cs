using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class ReindexComponent
    {
        public decimal Id { get; set; }
        public decimal? RequestId { get; set; }
        public string AffectedIndex { get; set; }
        public string EntityType { get; set; }
    }
}
