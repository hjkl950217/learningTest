using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Priority
    {
        public string Id { get; set; }
        public decimal? Sequence { get; set; }
        public string Pname { get; set; }
        public string Description { get; set; }
        public string Iconurl { get; set; }
        public string StatusColor { get; set; }
    }
}
