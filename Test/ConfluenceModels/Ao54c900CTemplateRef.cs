using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao54c900CTemplateRef
    {
        public Ao54c900CTemplateRef()
        {
            Ao54c900SpaceBlueprintAo = new HashSet<Ao54c900SpaceBlueprintAo>();
            InverseParent = new HashSet<Ao54c900CTemplateRef>();
        }

        public int? CbIndexParentid { get; set; }
        public int? CbParentid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public bool? PluginClone { get; set; }
        public string PluginModuleKey { get; set; }
        public long? TemplateId { get; set; }
        public string Uuid { get; set; }

        public Ao54c900ContentBlueprintAo CbIndexParent { get; set; }
        public Ao54c900ContentBlueprintAo CbParent { get; set; }
        public Ao54c900CTemplateRef Parent { get; set; }
        public ICollection<Ao54c900SpaceBlueprintAo> Ao54c900SpaceBlueprintAo { get; set; }
        public ICollection<Ao54c900CTemplateRef> InverseParent { get; set; }
    }
}
