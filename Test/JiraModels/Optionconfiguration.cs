using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Optionconfiguration
    {
        public decimal Id { get; set; }
        public string Fieldid { get; set; }
        public string Optionid { get; set; }
        public decimal? Fieldconfig { get; set; }
        public decimal? Sequence { get; set; }
    }
}
