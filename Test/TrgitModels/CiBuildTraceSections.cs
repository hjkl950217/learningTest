using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiBuildTraceSections
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public long ByteStart { get; set; }
        public long ByteEnd { get; set; }
        public int BuildId { get; set; }
        public int SectionNameId { get; set; }

        public CiBuilds Build { get; set; }
        public Projects Project { get; set; }
        public CiBuildTraceSectionNames SectionName { get; set; }
    }
}
