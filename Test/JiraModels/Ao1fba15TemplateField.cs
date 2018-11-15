using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao1fba15TemplateField
    {
        public string FieldName { get; set; }
        public int Id { get; set; }
        public int? TemplateId { get; set; }
        public string Value { get; set; }

        public Ao1fba15Template Template { get; set; }
    }
}
