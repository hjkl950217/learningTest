using System;
using System.Collections.Generic;
using System.Text;

namespace ColdChain.Entity.BaseInfo
{
    public interface ICreationAudited<T>
    {
        T CreatorUser { get; set; }
        long? CreatorUserId { get; set; }
        DateTime CreationTime { get; set; }
    }
}