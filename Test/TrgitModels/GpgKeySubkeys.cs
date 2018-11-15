using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class GpgKeySubkeys
    {
        public GpgKeySubkeys()
        {
            GpgSignatures = new HashSet<GpgSignatures>();
        }

        public int Id { get; set; }
        public int GpgKeyId { get; set; }
        public byte[] Keyid { get; set; }
        public byte[] Fingerprint { get; set; }

        public GpgKeys GpgKey { get; set; }
        public ICollection<GpgSignatures> GpgSignatures { get; set; }
    }
}
