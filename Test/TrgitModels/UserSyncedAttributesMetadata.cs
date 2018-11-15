using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class UserSyncedAttributesMetadata
    {
        public int Id { get; set; }
        public bool? NameSynced { get; set; }
        public bool? EmailSynced { get; set; }
        public bool? LocationSynced { get; set; }
        public int UserId { get; set; }
        public string Provider { get; set; }

        public Users User { get; set; }
    }
}
