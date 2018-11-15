using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Jiraissue
    {
        public decimal Id { get; set; }
        public string Pkey { get; set; }
        public decimal? Project { get; set; }
        public string Reporter { get; set; }
        public string Assignee { get; set; }
        public string Issuetype { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Environment { get; set; }
        public string Priority { get; set; }
        public string Resolution { get; set; }
        public string Issuestatus { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Duedate { get; set; }
        public DateTime? Resolutiondate { get; set; }
        public decimal? Votes { get; set; }
        public decimal? Watches { get; set; }
        public decimal? Timeoriginalestimate { get; set; }
        public decimal? Timeestimate { get; set; }
        public decimal? Timespent { get; set; }
        public decimal? WorkflowId { get; set; }
        public decimal? Security { get; set; }
        public decimal? Fixfor { get; set; }
        public decimal? Component { get; set; }
        public decimal? Issuenum { get; set; }
        public string Creator { get; set; }
    }
}
