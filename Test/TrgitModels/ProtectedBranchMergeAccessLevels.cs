using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProtectedBranchMergeAccessLevels
    {
        public int Id { get; set; }
        public int ProtectedBranchId { get; set; }
        public int AccessLevel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ProtectedBranches ProtectedBranch { get; set; }
    }
}
