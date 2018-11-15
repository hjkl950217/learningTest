using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Avatar
    {
        public decimal Id { get; set; }
        public string Filename { get; set; }
        public string Contenttype { get; set; }
        public string Avatartype { get; set; }
        public string Owner { get; set; }
        public int? Systemavatar { get; set; }
    }
}
