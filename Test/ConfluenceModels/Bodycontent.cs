using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Bodycontent
    {
        public decimal Bodycontentid { get; set; }
        public string Body { get; set; }
        public decimal? Contentid { get; set; }
        public short? Bodytypeid { get; set; }

        public Content Content { get; set; }
    }
}
