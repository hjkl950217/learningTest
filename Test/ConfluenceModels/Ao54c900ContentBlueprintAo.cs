using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao54c900ContentBlueprintAo
    {
        public Ao54c900ContentBlueprintAo()
        {
            Ao54c900CTemplateRefCbIndexParent = new HashSet<Ao54c900CTemplateRef>();
            Ao54c900CTemplateRefCbParent = new HashSet<Ao54c900CTemplateRef>();
        }

        public string CreateResult { get; set; }
        public string HowToUseTemplate { get; set; }
        public int Id { get; set; }
        public bool? IndexDisabled { get; set; }
        public string IndexKey { get; set; }
        public string IndexTitleI18nKey { get; set; }
        public string Name { get; set; }
        public bool? PluginClone { get; set; }
        public string PluginModuleKey { get; set; }
        public string SpaceKey { get; set; }
        public string Uuid { get; set; }

        public ICollection<Ao54c900CTemplateRef> Ao54c900CTemplateRefCbIndexParent { get; set; }
        public ICollection<Ao54c900CTemplateRef> Ao54c900CTemplateRefCbParent { get; set; }
    }
}
