using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Trustedapprestriction
    {
        public decimal Trustedapprestrictionid { get; set; }
        public string Type { get; set; }
        public string Restriction { get; set; }
        public decimal? Trustedappid { get; set; }

        public Trustedapp Trustedapp { get; set; }
    }
}
