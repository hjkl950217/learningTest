using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class ExternalMembers
    {
        public decimal Extentityid { get; set; }
        public decimal Groupid { get; set; }

        public ExternalEntities Extentity { get; set; }
        public Groups Group { get; set; }
    }
}
