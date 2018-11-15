using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Project
    {
        public decimal Id { get; set; }
        public string Pname { get; set; }
        public string Url { get; set; }
        public string Lead { get; set; }
        public string Description { get; set; }
        public string Pkey { get; set; }
        public decimal? Pcounter { get; set; }
        public decimal? Assigneetype { get; set; }
        public decimal? Avatar { get; set; }
        public string Originalkey { get; set; }
        public string Projecttype { get; set; }
    }
}
