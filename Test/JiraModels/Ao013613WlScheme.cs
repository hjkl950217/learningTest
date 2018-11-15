using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao013613WlScheme
    {
        public Ao013613WlScheme()
        {
            Ao013613WlSchemeDay = new HashSet<Ao013613WlSchemeDay>();
            Ao013613WlSchemeMember = new HashSet<Ao013613WlSchemeMember>();
        }

        public bool? DefaultScheme { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ao013613WlSchemeDay> Ao013613WlSchemeDay { get; set; }
        public ICollection<Ao013613WlSchemeMember> Ao013613WlSchemeMember { get; set; }
    }
}
