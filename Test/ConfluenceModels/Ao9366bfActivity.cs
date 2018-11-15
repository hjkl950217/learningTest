using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao9366bfActivity
    {
        public string ActorId { get; set; }
        public int? BoardId { get; set; }
        public long Created { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public long Updated { get; set; }

        public Ao9366bfBoard Board { get; set; }
    }
}
