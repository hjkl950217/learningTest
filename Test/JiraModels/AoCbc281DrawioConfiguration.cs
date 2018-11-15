using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoCbc281DrawioConfiguration
    {
        public string CustomTemplatesCfgPageUrl { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? NotifyOnDiagramEdit { get; set; }
        public long? ResampleThreshold { get; set; }
        public string ServerConfig { get; set; }
        public string UiConfig { get; set; }
        public bool? UseExternalImageService { get; set; }
    }
}
