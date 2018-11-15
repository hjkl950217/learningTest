using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao9366bfCardComment
    {
        public string AuthorId { get; set; }
        public int? CardId { get; set; }
        public string Content { get; set; }
        public long Created { get; set; }
        public int Id { get; set; }
        public long Updated { get; set; }

        public Ao9366bfCard Card { get; set; }
    }
}
