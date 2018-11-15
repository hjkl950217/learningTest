using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class JquartzCalendars
    {
        public string SchedName { get; set; }
        public string CalendarName { get; set; }
        public byte[] Calendar { get; set; }
    }
}
