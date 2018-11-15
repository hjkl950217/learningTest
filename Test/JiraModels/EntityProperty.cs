using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class EntityProperty
    {
        public decimal Id { get; set; }
        public string EntityName { get; set; }
        public decimal? EntityId { get; set; }
        public string PropertyKey { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string JsonValue { get; set; }
    }
}
