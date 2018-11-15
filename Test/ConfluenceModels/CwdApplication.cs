using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdApplication
    {
        public CwdApplication()
        {
            CwdAppDirGroupMapping = new HashSet<CwdAppDirGroupMapping>();
            CwdAppDirMapping = new HashSet<CwdAppDirMapping>();
            CwdApplicationAddress = new HashSet<CwdApplicationAddress>();
            CwdApplicationAttribute = new HashSet<CwdApplicationAttribute>();
        }

        public decimal Id { get; set; }
        public string ApplicationName { get; set; }
        public string LowerApplicationName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Active { get; set; }
        public string Description { get; set; }
        public string ApplicationType { get; set; }
        public string Credential { get; set; }

        public ICollection<CwdAppDirGroupMapping> CwdAppDirGroupMapping { get; set; }
        public ICollection<CwdAppDirMapping> CwdAppDirMapping { get; set; }
        public ICollection<CwdApplicationAddress> CwdApplicationAddress { get; set; }
        public ICollection<CwdApplicationAttribute> CwdApplicationAttribute { get; set; }
    }
}
