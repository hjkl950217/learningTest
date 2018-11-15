using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoCbc281DrawioLibrary
    {
        public AoCbc281DrawioLibrary()
        {
            AoCbc281DefLibForGroup = new HashSet<AoCbc281DefLibForGroup>();
        }

        public bool AnyoneCanEdit { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }
        public DateTime LastModified { get; set; }
        public string Name { get; set; }
        public string Xml { get; set; }

        public ICollection<AoCbc281DefLibForGroup> AoCbc281DefLibForGroup { get; set; }
    }
}
