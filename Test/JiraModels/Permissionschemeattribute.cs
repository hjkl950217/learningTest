using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Permissionschemeattribute
    {
        public decimal Id { get; set; }
        public decimal? Scheme { get; set; }
        public string AttributeKey { get; set; }
        public string AttributeValue { get; set; }
    }
}
