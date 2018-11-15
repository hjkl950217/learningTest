using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdDirectoryOperation
    {
        public decimal DirectoryId { get; set; }
        public string OperationType { get; set; }

        public CwdDirectory Directory { get; set; }
    }
}
