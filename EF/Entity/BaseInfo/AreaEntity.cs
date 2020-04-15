using System;
using System.Collections.Generic;
using System.Text;

namespace ColdChain.Entity.BaseInfo
{
    public class AreaEntity
    {
        public byte AreaLevel { get; set; }
        public string AreaCode { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public AreaEntity Parent { get; set; }
        public ICollection<AreaEntity> Child { get; set; }
    }

    public class AreaConfig
    {
        public const int AreaCodeMaxLength = 15;
        public const int NameMaxLength = 100;
    }
}