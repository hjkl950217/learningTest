using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdAppDirMapping
    {
        public CwdAppDirMapping()
        {
            CwdAppDirGroupMapping = new HashSet<CwdAppDirGroupMapping>();
            CwdAppDirOperation = new HashSet<CwdAppDirOperation>();
        }

        public decimal Id { get; set; }
        public decimal? ApplicationId { get; set; }
        public decimal DirectoryId { get; set; }
        public string AllowAll { get; set; }
        public int? ListIndex { get; set; }

        public CwdApplication Application { get; set; }
        public CwdDirectory Directory { get; set; }
        public ICollection<CwdAppDirGroupMapping> CwdAppDirGroupMapping { get; set; }
        public ICollection<CwdAppDirOperation> CwdAppDirOperation { get; set; }
    }
}
