using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Votehistory
    {
        public decimal Id { get; set; }
        public decimal? Issueid { get; set; }
        public decimal? Votes { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
