using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Managedconfigurationitem
    {
        public decimal Id { get; set; }
        public string ItemId { get; set; }
        public string ItemType { get; set; }
        public string Managed { get; set; }
        public string AccessLevel { get; set; }
        public string Source { get; set; }
        public string DescriptionKey { get; set; }
    }
}
