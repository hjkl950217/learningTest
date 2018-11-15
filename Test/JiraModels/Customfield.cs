using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Customfield
    {
        public decimal Id { get; set; }
        public string Customfieldtypekey { get; set; }
        public string Customfieldsearcherkey { get; set; }
        public string Cfname { get; set; }
        public string Description { get; set; }
        public string Defaultvalue { get; set; }
        public decimal? Fieldtype { get; set; }
        public decimal? Project { get; set; }
        public string Issuetype { get; set; }
        public string Cfkey { get; set; }
    }
}
