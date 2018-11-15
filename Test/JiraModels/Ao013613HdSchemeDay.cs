using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao013613HdSchemeDay
    {
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public long? DurationSeconds { get; set; }
        public int? HolidaySchemeId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Ao013613HdScheme HolidayScheme { get; set; }
    }
}
