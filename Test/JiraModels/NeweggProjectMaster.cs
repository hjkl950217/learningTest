using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class NeweggProjectMaster
    {
        public decimal Id { get; set; }
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
        public string Creater { get; set; }
        public DateTime? Updated { get; set; }
        public string Updater { get; set; }
        public string Detail { get; set; }
    }
}
