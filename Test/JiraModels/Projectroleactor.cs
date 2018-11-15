using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Projectroleactor
    {
        public decimal Id { get; set; }
        public decimal? Pid { get; set; }
        public decimal? Projectroleid { get; set; }
        public string Roletype { get; set; }
        public string Roletypeparameter { get; set; }
    }
}
