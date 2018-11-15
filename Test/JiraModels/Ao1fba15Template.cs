using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao1fba15Template
    {
        public Ao1fba15Template()
        {
            Ao1fba15TemplateField = new HashSet<Ao1fba15TemplateField>();
        }

        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }

        public ICollection<Ao1fba15TemplateField> Ao1fba15TemplateField { get; set; }
    }
}
