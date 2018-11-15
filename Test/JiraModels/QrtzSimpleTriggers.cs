using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class QrtzSimpleTriggers
    {
        public decimal Id { get; set; }
        public decimal? TriggerId { get; set; }
        public int? RepeatCount { get; set; }
        public decimal? RepeatInterval { get; set; }
        public int? TimesTriggered { get; set; }
    }
}
