using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiBuildTraceSectionNames
    {
        public CiBuildTraceSectionNames()
        {
            CiBuildTraceSections = new HashSet<CiBuildTraceSections>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }

        public Projects Project { get; set; }
        public ICollection<CiBuildTraceSections> CiBuildTraceSections { get; set; }
    }
}
