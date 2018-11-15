using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao9366bfBoard
    {
        public Ao9366bfBoard()
        {
            Ao9366bfActivity = new HashSet<Ao9366bfActivity>();
            Ao9366bfList = new HashSet<Ao9366bfList>();
        }

        public long Created { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public long? PageId { get; set; }
        public string Title { get; set; }
        public long Updated { get; set; }

        public ICollection<Ao9366bfActivity> Ao9366bfActivity { get; set; }
        public ICollection<Ao9366bfList> Ao9366bfList { get; set; }
    }
}
