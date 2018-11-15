using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiPipelineScheduleVariables
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string EncryptedValue { get; set; }
        public string EncryptedValueSalt { get; set; }
        public string EncryptedValueIv { get; set; }
        public int PipelineScheduleId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public CiPipelineSchedules PipelineSchedule { get; set; }
    }
}
