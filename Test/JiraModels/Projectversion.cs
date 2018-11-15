using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Projectversion
    {
        public decimal Id { get; set; }
        public decimal? Project { get; set; }
        public string Vname { get; set; }
        public string Description { get; set; }
        public decimal? Sequence { get; set; }
        public string Released { get; set; }
        public string Archived { get; set; }
        public string Url { get; set; }
        public DateTime? Releasedate { get; set; }
        public DateTime? Startdate { get; set; }
    }
}
