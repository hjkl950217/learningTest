using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Notification
    {
        public decimal Id { get; set; }
        public decimal? Scheme { get; set; }
        public string Event { get; set; }
        public decimal? EventTypeId { get; set; }
        public decimal? TemplateId { get; set; }
        public string NotifType { get; set; }
        public string NotifParameter { get; set; }
    }
}
