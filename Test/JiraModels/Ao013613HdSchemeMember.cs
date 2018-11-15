using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao013613HdSchemeMember
    {
        public int? HolidaySchemeId { get; set; }
        public int Id { get; set; }
        public string UserKey { get; set; }

        public Ao013613HdScheme HolidayScheme { get; set; }
    }
}
