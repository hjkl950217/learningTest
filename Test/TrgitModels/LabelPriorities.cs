using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class LabelPriorities
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int LabelId { get; set; }
        public int Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Labels Label { get; set; }
        public Projects Project { get; set; }
    }
}
