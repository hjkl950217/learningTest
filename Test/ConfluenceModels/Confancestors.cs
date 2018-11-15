using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Confancestors
    {
        public decimal Descendentid { get; set; }
        public decimal Ancestorid { get; set; }
        public int Ancestorposition { get; set; }

        public Content Ancestor { get; set; }
        public Content Descendent { get; set; }
    }
}
