using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao54c900SpaceBlueprintAo
    {
        public string Category { get; set; }
        public int? HomePageId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? PluginClone { get; set; }
        public string PluginModuleKey { get; set; }
        public string PromotedBps { get; set; }
        public string Uuid { get; set; }

        public Ao54c900CTemplateRef HomePage { get; set; }
    }
}
