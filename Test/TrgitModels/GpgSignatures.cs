using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class GpgSignatures
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? ProjectId { get; set; }
        public int? GpgKeyId { get; set; }
        public byte[] CommitSha { get; set; }
        public byte[] GpgKeyPrimaryKeyid { get; set; }
        public string GpgKeyUserName { get; set; }
        public string GpgKeyUserEmail { get; set; }
        public short VerificationStatus { get; set; }
        public int? GpgKeySubkeyId { get; set; }

        public GpgKeys GpgKey { get; set; }
        public GpgKeySubkeys GpgKeySubkey { get; set; }
        public Projects Project { get; set; }
    }
}
