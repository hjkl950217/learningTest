using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class LocalMembers
    {
        public decimal Userid { get; set; }
        public decimal Groupid { get; set; }

        public Groups Group { get; set; }
        public Users User { get; set; }
    }
}
