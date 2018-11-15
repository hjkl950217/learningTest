using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdAppDirOperation
    {
        public decimal AppDirMappingId { get; set; }
        public string OperationType { get; set; }

        public CwdAppDirMapping AppDirMapping { get; set; }
    }
}
