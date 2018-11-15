using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Draftworkflowschemeentity
    {
        public decimal Id { get; set; }
        public decimal? Scheme { get; set; }
        public string Workflow { get; set; }
        public string Issuetype { get; set; }
    }
}
