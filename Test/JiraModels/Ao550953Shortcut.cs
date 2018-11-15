using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao550953Shortcut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? ProjectId { get; set; }
        public string ShortcutUrl { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
