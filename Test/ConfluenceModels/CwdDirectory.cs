using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdDirectory
    {
        public CwdDirectory()
        {
            CwdAppDirGroupMapping = new HashSet<CwdAppDirGroupMapping>();
            CwdAppDirMapping = new HashSet<CwdAppDirMapping>();
            CwdDirectoryAttribute = new HashSet<CwdDirectoryAttribute>();
            CwdDirectoryOperation = new HashSet<CwdDirectoryOperation>();
            CwdGroup = new HashSet<CwdGroup>();
            CwdGroupAttribute = new HashSet<CwdGroupAttribute>();
            CwdUser = new HashSet<CwdUser>();
            CwdUserAttribute = new HashSet<CwdUserAttribute>();
        }

        public decimal Id { get; set; }
        public string DirectoryName { get; set; }
        public string LowerDirectoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Active { get; set; }
        public string Description { get; set; }
        public string ImplClass { get; set; }
        public string LowerImplClass { get; set; }
        public string DirectoryType { get; set; }

        public ICollection<CwdAppDirGroupMapping> CwdAppDirGroupMapping { get; set; }
        public ICollection<CwdAppDirMapping> CwdAppDirMapping { get; set; }
        public ICollection<CwdDirectoryAttribute> CwdDirectoryAttribute { get; set; }
        public ICollection<CwdDirectoryOperation> CwdDirectoryOperation { get; set; }
        public ICollection<CwdGroup> CwdGroup { get; set; }
        public ICollection<CwdGroupAttribute> CwdGroupAttribute { get; set; }
        public ICollection<CwdUser> CwdUser { get; set; }
        public ICollection<CwdUserAttribute> CwdUserAttribute { get; set; }
    }
}
