using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Worklog
    {
        public decimal Id { get; set; }
        public decimal? Issueid { get; set; }
        public string Author { get; set; }
        public string Grouplevel { get; set; }
        public decimal? Rolelevel { get; set; }
        public string Worklogbody { get; set; }
        public DateTime? Created { get; set; }
        public string Updateauthor { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Startdate { get; set; }
        public decimal? Timeworked { get; set; }
    }
}
