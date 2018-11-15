using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Nonworkingday
    {
        public long Id { get; set; }
        public string Iso8601Date { get; set; }
        public long WorkingDaysId { get; set; }

        public Ao60db71Workingdays WorkingDays { get; set; }
    }
}
