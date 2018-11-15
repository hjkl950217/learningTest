using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Filtersubscription
    {
        public decimal Id { get; set; }
        public decimal? FilterID { get; set; }
        public string Username { get; set; }
        public string Groupname { get; set; }
        public DateTime? LastRun { get; set; }
        public string EmailOnEmpty { get; set; }
    }
}
