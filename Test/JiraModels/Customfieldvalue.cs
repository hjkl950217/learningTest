using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Customfieldvalue
    {
        public decimal Id { get; set; }
        public decimal? Issue { get; set; }
        public decimal? Customfield { get; set; }
        public string Parentkey { get; set; }
        public string Stringvalue { get; set; }
        public decimal? Numbervalue { get; set; }
        public string Textvalue { get; set; }
        public DateTime? Datevalue { get; set; }
        public string Valuetype { get; set; }
        public decimal? Updated { get; set; }
    }
}
