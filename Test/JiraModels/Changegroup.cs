using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Changegroup
    {
        public decimal Id { get; set; }
        public decimal? Issueid { get; set; }
        public string Author { get; set; }
        public DateTime? Created { get; set; }
    }
}
