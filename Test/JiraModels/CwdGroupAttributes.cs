using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class CwdGroupAttributes
    {
        public decimal Id { get; set; }
        public decimal? GroupId { get; set; }
        public decimal? DirectoryId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public string LowerAttributeValue { get; set; }
    }
}
