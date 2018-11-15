using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class AoA3f2efLayoutItem
    {
        public string Content { get; set; }
        public string DefaultParameterValue { get; set; }
        public int Id { get; set; }
        public string ItemId { get; set; }
        public int? LayoutSectionId { get; set; }
        public bool? Locked { get; set; }
        public string MacroName { get; set; }
        public string Params { get; set; }
        public int? Position { get; set; }

        public AoA3f2efLayoutSection LayoutSection { get; set; }
    }
}
