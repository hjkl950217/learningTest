using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProtectedBranches
    {
        public ProtectedBranches()
        {
            ProtectedBranchMergeAccessLevels = new HashSet<ProtectedBranchMergeAccessLevels>();
            ProtectedBranchPushAccessLevels = new HashSet<ProtectedBranchPushAccessLevels>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Projects Project { get; set; }
        public ICollection<ProtectedBranchMergeAccessLevels> ProtectedBranchMergeAccessLevels { get; set; }
        public ICollection<ProtectedBranchPushAccessLevels> ProtectedBranchPushAccessLevels { get; set; }
    }
}
