using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class GpgKeys
    {
        public GpgKeys()
        {
            GpgKeySubkeys = new HashSet<GpgKeySubkeys>();
            GpgSignatures = new HashSet<GpgSignatures>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? UserId { get; set; }
        public byte[] PrimaryKeyid { get; set; }
        public byte[] Fingerprint { get; set; }
        public string Key { get; set; }

        public Users User { get; set; }
        public ICollection<GpgKeySubkeys> GpgKeySubkeys { get; set; }
        public ICollection<GpgSignatures> GpgSignatures { get; set; }
    }
}
