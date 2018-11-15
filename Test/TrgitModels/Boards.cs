using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Boards
    {
        public Boards()
        {
            Lists = new HashSet<Lists>();
        }

        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? GroupId { get; set; }

        public Namespaces Group { get; set; }
        public Projects Project { get; set; }
        public ICollection<Lists> Lists { get; set; }
    }
}
