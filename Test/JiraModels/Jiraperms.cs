using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Jiraperms
    {
        public decimal Id { get; set; }
        public decimal? Permtype { get; set; }
        public decimal? Projectid { get; set; }
        public string Groupname { get; set; }
    }
}
