using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class AoA3f2efLayoutSection
    {
        public AoA3f2efLayoutSection()
        {
            AoA3f2efLayoutItem = new HashSet<AoA3f2efLayoutItem>();
        }

        public int? Group { get; set; }
        public int Id { get; set; }
        public int? LayoutBoardId { get; set; }
        public int? LayuoutBoardId { get; set; }
        public int? Position { get; set; }
        public string SectionId { get; set; }
        public int? Width { get; set; }

        public AoA3f2efLayoutBoard LayoutBoard { get; set; }
        public AoA3f2efLayoutBoard LayuoutBoard { get; set; }
        public ICollection<AoA3f2efLayoutItem> AoA3f2efLayoutItem { get; set; }
    }
}
