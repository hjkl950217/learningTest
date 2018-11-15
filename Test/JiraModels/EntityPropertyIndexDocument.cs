using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class EntityPropertyIndexDocument
    {
        public decimal Id { get; set; }
        public string PluginKey { get; set; }
        public string ModuleKey { get; set; }
        public string EntityKey { get; set; }
        public DateTime? Updated { get; set; }
        public string Document { get; set; }
    }
}
