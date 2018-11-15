using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class U2fRegistrations
    {
        public int Id { get; set; }
        public string Certificate { get; set; }
        public string KeyHandle { get; set; }
        public string PublicKey { get; set; }
        public int? Counter { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }

        public Users User { get; set; }
    }
}
