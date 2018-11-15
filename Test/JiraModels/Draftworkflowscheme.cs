using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Draftworkflowscheme
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? WorkflowSchemeId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
    }
}
