using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class GroupCustomAttributes
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int GroupId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public Namespaces Group { get; set; }
    }
}
