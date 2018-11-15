using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Notificationinstance
    {
        public decimal Id { get; set; }
        public string Notificationtype { get; set; }
        public decimal? Source { get; set; }
        public string Emailaddress { get; set; }
        public string Messageid { get; set; }
    }
}
