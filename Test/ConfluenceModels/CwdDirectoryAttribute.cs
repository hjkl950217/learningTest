using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdDirectoryAttribute
    {
        public decimal DirectoryId { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeName { get; set; }

        public CwdDirectory Directory { get; set; }
    }
}
