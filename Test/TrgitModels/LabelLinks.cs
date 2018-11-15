using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class LabelLinks
    {
        public int Id { get; set; }
        public int? LabelId { get; set; }
        public int? TargetId { get; set; }
        public string TargetType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
