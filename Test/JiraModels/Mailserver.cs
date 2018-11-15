using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Mailserver
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mailfrom { get; set; }
        public string Prefix { get; set; }
        public string SmtpPort { get; set; }
        public string Protocol { get; set; }
        public string ServerType { get; set; }
        public string Servername { get; set; }
        public string Jndilocation { get; set; }
        public string Mailusername { get; set; }
        public string Mailpassword { get; set; }
        public string Istlsrequired { get; set; }
        public decimal? Timeout { get; set; }
        public string SocksPort { get; set; }
        public string SocksHost { get; set; }
    }
}
