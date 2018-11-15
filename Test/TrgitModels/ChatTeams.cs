using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ChatTeams
    {
        public int Id { get; set; }
        public int NamespaceId { get; set; }
        public string TeamId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Namespaces Namespace { get; set; }
    }
}
