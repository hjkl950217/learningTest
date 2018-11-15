using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao013613HdScheme
    {
        public Ao013613HdScheme()
        {
            Ao013613HdSchemeDay = new HashSet<Ao013613HdSchemeDay>();
            Ao013613HdSchemeMember = new HashSet<Ao013613HdSchemeMember>();
        }

        public bool? DefaultScheme { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ao013613HdSchemeDay> Ao013613HdSchemeDay { get; set; }
        public ICollection<Ao013613HdSchemeMember> Ao013613HdSchemeMember { get; set; }
    }
}
