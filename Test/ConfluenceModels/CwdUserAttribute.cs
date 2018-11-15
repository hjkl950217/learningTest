using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdUserAttribute
    {
        public decimal Id { get; set; }
        public decimal UserId { get; set; }
        public decimal DirectoryId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeLowerValue { get; set; }

        public CwdDirectory Directory { get; set; }
        public CwdUser User { get; set; }
    }
}
