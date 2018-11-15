using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Jiraaction
    {
        public decimal Id { get; set; }
        public decimal? Issueid { get; set; }
        public string Author { get; set; }
        public string Actiontype { get; set; }
        public string Actionlevel { get; set; }
        public decimal? Rolelevel { get; set; }
        public string Actionbody { get; set; }
        public DateTime? Created { get; set; }
        public string Updateauthor { get; set; }
        public DateTime? Updated { get; set; }
        public decimal? Actionnum { get; set; }
    }
}
