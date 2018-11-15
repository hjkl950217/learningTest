using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdGroupAttribute
    {
        public decimal Id { get; set; }
        public decimal GroupId { get; set; }
        public decimal DirectoryId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeLowerValue { get; set; }

        public CwdDirectory Directory { get; set; }
        public CwdGroup Group { get; set; }
    }
}
