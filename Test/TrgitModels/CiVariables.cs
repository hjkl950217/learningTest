using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiVariables
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string EncryptedValue { get; set; }
        public string EncryptedValueSalt { get; set; }
        public string EncryptedValueIv { get; set; }
        public int ProjectId { get; set; }
        public bool Protected { get; set; }
        public string EnvironmentScope { get; set; }

        public Projects Project { get; set; }
    }
}
