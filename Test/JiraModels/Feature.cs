using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Feature
    {
        public decimal Id { get; set; }
        public string FeatureName { get; set; }
        public string FeatureType { get; set; }
        public string UserKey { get; set; }
    }
}
