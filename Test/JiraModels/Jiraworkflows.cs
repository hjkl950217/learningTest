using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Jiraworkflows
    {
        public decimal Id { get; set; }
        public string Workflowname { get; set; }
        public string Creatorname { get; set; }
        public string Descriptor { get; set; }
        public string Islocked { get; set; }
    }
}
