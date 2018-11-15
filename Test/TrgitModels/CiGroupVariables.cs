using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiGroupVariables
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string EncryptedValue { get; set; }
        public string EncryptedValueSalt { get; set; }
        public string EncryptedValueIv { get; set; }
        public int GroupId { get; set; }
        public bool Protected { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Namespaces Group { get; set; }
    }
}
