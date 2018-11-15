using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProjectImportData
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string Data { get; set; }
        public string EncryptedCredentials { get; set; }
        public string EncryptedCredentialsIv { get; set; }
        public string EncryptedCredentialsSalt { get; set; }

        public Projects Project { get; set; }
    }
}
