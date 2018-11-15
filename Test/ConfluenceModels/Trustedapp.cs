using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Trustedapp
    {
        public Trustedapp()
        {
            Trustedapprestriction = new HashSet<Trustedapprestriction>();
        }

        public decimal Trustedappid { get; set; }
        public string Name { get; set; }
        public int Timeout { get; set; }
        public decimal PublicKeyId { get; set; }

        public Keystore PublicKey { get; set; }
        public ICollection<Trustedapprestriction> Trustedapprestriction { get; set; }
    }
}
