using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class AoA3f2efLayoutBoard
    {
        public AoA3f2efLayoutBoard()
        {
            AoA3f2efLayoutSectionLayoutBoard = new HashSet<AoA3f2efLayoutSection>();
            AoA3f2efLayoutSectionLayuoutBoard = new HashSet<AoA3f2efLayoutSection>();
        }

        public string ContentKey { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<AoA3f2efLayoutSection> AoA3f2efLayoutSectionLayoutBoard { get; set; }
        public ICollection<AoA3f2efLayoutSection> AoA3f2efLayoutSectionLayuoutBoard { get; set; }
    }
}
