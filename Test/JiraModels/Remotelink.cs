using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Remotelink
    {
        public decimal Id { get; set; }
        public decimal? Issueid { get; set; }
        public string Globalid { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
        public string Iconurl { get; set; }
        public string Icontitle { get; set; }
        public string Relationship { get; set; }
        public string Resolved { get; set; }
        public string Statusiconurl { get; set; }
        public string Statusicontitle { get; set; }
        public string Statusiconlink { get; set; }
        public string Applicationtype { get; set; }
        public string Applicationname { get; set; }
        public string Statusname { get; set; }
        public string Statusdescription { get; set; }
        public string Statuscategorycolorname { get; set; }
        public string Statuscategorykey { get; set; }
    }
}
