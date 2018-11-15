using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao9366bfList
    {
        public Ao9366bfList()
        {
            Ao9366bfCard = new HashSet<Ao9366bfCard>();
        }

        public bool? Archived { get; set; }
        public int? BoardId { get; set; }
        public long Created { get; set; }
        public int Id { get; set; }
        public int? Position { get; set; }
        public string Title { get; set; }
        public long Updated { get; set; }

        public Ao9366bfBoard Board { get; set; }
        public ICollection<Ao9366bfCard> Ao9366bfCard { get; set; }
    }
}
