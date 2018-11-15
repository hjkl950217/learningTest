using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class AwardEmoji
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
        public int? AwardableId { get; set; }
        public string AwardableType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
