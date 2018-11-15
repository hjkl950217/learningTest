using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Events
    {
        public string Rev { get; set; }
        public string History { get; set; }
        public int Partition { get; set; }
        public int Sequence { get; set; }
        public byte[] Event { get; set; }
    }
}
