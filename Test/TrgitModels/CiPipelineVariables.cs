using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiPipelineVariables
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string EncryptedValue { get; set; }
        public string EncryptedValueSalt { get; set; }
        public string EncryptedValueIv { get; set; }
        public int PipelineId { get; set; }

        public CiPipelines Pipeline { get; set; }
    }
}
