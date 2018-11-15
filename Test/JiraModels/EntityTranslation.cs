using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class EntityTranslation
    {
        public decimal Id { get; set; }
        public string EntityName { get; set; }
        public decimal? EntityId { get; set; }
        public string Locale { get; set; }
        public string TransName { get; set; }
        public string TransDesc { get; set; }
    }
}
