using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ForkNetworkMembers
    {
        public int Id { get; set; }
        public int ForkNetworkId { get; set; }
        public int ProjectId { get; set; }
        public int? ForkedFromProjectId { get; set; }

        public ForkNetworks ForkNetwork { get; set; }
        public Projects ForkedFromProject { get; set; }
        public Projects Project { get; set; }
    }
}
