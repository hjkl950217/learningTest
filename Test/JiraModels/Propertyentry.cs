using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Propertyentry
    {
        public decimal Id { get; set; }
        public string EntityName { get; set; }
        public decimal? EntityId { get; set; }
        public string PropertyKey { get; set; }
        public int? Propertytype { get; set; }
    }
}
