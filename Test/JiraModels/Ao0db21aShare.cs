using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao0db21aShare
    {
        public int? CalendarId { get; set; }
        public string Group { get; set; }
        public int Id { get; set; }
        public long? Project { get; set; }
        public long? Role { get; set; }

        public Ao0db21aCalendar Calendar { get; set; }
    }
}
