using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoCbc281DefLibForGroup
    {
        public string GroupName { get; set; }
        public int Id { get; set; }
        public int? LibraryId { get; set; }

        public AoCbc281DrawioLibrary Library { get; set; }
    }
}
