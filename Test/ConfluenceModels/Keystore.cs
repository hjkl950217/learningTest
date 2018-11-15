using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Keystore
    {
        public decimal Keyid { get; set; }
        public string Alias { get; set; }
        public string Type { get; set; }
        public string Algorithm { get; set; }
        public string Keyspec { get; set; }

        public Trustedapp Trustedapp { get; set; }
    }
}
