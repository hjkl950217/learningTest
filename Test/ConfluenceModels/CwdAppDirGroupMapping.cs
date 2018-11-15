using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdAppDirGroupMapping
    {
        public decimal Id { get; set; }
        public decimal AppDirMappingId { get; set; }
        public decimal ApplicationId { get; set; }
        public decimal DirectoryId { get; set; }
        public string GroupName { get; set; }

        public CwdAppDirMapping AppDirMapping { get; set; }
        public CwdApplication Application { get; set; }
        public CwdDirectory Directory { get; set; }
    }
}
