using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Portletconfiguration
    {
        public decimal Id { get; set; }
        public decimal? Portalpage { get; set; }
        public string PortletId { get; set; }
        public int? ColumnNumber { get; set; }
        public int? Positionseq { get; set; }
        public string GadgetXml { get; set; }
        public string Color { get; set; }
        public string DashboardModuleCompleteKey { get; set; }
    }
}
