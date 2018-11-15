using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao6d89bfDrawioLibrary
    {
        public Ao6d89bfDrawioLibrary()
        {
            Ao6d89bfDefLibForGroup = new HashSet<Ao6d89bfDefLibForGroup>();
        }

        public bool AnyoneCanEdit { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }
        public DateTime LastModified { get; set; }
        public string Name { get; set; }
        public string Xml { get; set; }

        public ICollection<Ao6d89bfDefLibForGroup> Ao6d89bfDefLibForGroup { get; set; }
    }
}
