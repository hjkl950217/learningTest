using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class PagesDomains
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string Certificate { get; set; }
        public string EncryptedKey { get; set; }
        public string EncryptedKeyIv { get; set; }
        public string EncryptedKeySalt { get; set; }
        public string Domain { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public string VerificationCode { get; set; }
        public DateTime? EnabledUntil { get; set; }

        public Projects Project { get; set; }
    }
}
