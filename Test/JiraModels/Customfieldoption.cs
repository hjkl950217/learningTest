using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Customfieldoption
    {
        public decimal Id { get; set; }
        public decimal? Customfield { get; set; }
        public decimal? Customfieldconfig { get; set; }
        public decimal? Parentoptionid { get; set; }
        public decimal? Sequence { get; set; }
        public string Customvalue { get; set; }
        public string Optiontype { get; set; }
        public string Disabled { get; set; }
    }
}
