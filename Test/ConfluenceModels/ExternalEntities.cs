using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class ExternalEntities
    {
        public ExternalEntities()
        {
            ExternalMembers = new HashSet<ExternalMembers>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public ICollection<ExternalMembers> ExternalMembers { get; set; }
    }
}
