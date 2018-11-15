using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Lists
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public int? LabelId { get; set; }
        public int ListType { get; set; }
        public int? Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Boards Board { get; set; }
        public Labels Label { get; set; }
    }
}
