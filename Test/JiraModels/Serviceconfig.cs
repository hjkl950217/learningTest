using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Serviceconfig
    {
        public decimal Id { get; set; }
        public decimal? Delaytime { get; set; }
        public string Clazz { get; set; }
        public string Servicename { get; set; }
        public string CronExpression { get; set; }
    }
}
