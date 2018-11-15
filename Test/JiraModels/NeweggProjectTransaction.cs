using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class NeweggProjectTransaction
    {
        public decimal Id { get; set; }
        public string ProjectId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime? TransTime { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public string Creater { get; set; }
        public DateTime? Updated { get; set; }
        public string Updater { get; set; }
        public string Detail { get; set; }
        public string Value { get; set; }
        public string Group { get; set; }
    }
}
