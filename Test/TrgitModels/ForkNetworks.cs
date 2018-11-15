using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ForkNetworks
    {
        public ForkNetworks()
        {
            ForkNetworkMembers = new HashSet<ForkNetworkMembers>();
        }

        public int Id { get; set; }
        public int? RootProjectId { get; set; }
        public string DeletedRootProjectName { get; set; }

        public Projects RootProject { get; set; }
        public ICollection<ForkNetworkMembers> ForkNetworkMembers { get; set; }
    }
}
