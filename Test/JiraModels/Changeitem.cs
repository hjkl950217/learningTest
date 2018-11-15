using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Changeitem
    {
        public decimal Id { get; set; }
        public decimal? Groupid { get; set; }
        public string Fieldtype { get; set; }
        public string Field { get; set; }
        public string Oldvalue { get; set; }
        public string Oldstring { get; set; }
        public string Newvalue { get; set; }
        public string Newstring { get; set; }
    }
}
