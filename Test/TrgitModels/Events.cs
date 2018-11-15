using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Events
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int AuthorId { get; set; }
        public int? TargetId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public short Action { get; set; }
        public string TargetType { get; set; }

        public Users Author { get; set; }
        public Projects Project { get; set; }
    }
}
