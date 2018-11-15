using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Contentproperties
    {
        public decimal Propertyid { get; set; }
        public string Propertyname { get; set; }
        public string Stringval { get; set; }
        public decimal? Longval { get; set; }
        public DateTime? Dateval { get; set; }
        public decimal? Contentid { get; set; }

        public Content Content { get; set; }
    }
}
