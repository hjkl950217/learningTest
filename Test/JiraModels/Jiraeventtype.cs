using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Jiraeventtype
    {
        public decimal Id { get; set; }
        public decimal? TemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EventType { get; set; }
    }
}
