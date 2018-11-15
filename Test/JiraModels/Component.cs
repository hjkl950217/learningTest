using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Component
    {
        public decimal Id { get; set; }
        public decimal? Project { get; set; }
        public string Cname { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Lead { get; set; }
        public decimal? Assigneetype { get; set; }
    }
}
