using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Keys
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Fingerprint { get; set; }
        public bool Public { get; set; }
        public DateTime? LastUsedAt { get; set; }
    }
}
