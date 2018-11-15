using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Gadgetuserpreference
    {
        public decimal Id { get; set; }
        public decimal? Portletconfiguration { get; set; }
        public string Userprefkey { get; set; }
        public string Userprefvalue { get; set; }
    }
}
