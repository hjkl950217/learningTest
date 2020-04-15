using System;
using System.Collections.Generic;
using System.Text;
using ColdChain.EntityFramework;

namespace ColdChain.Entity.BaseInfo
{
    /// <summary>
    /// 运输线路
    /// </summary>
    public class TransportRouteEntity : Entity<long>, ICreationAudited<UserEntity>
    {
        /// <summary>
        /// 路线名称
        /// </summary>
        public string RouteName { get; set; }

        public string Remarks { get; set; }

        public ICollection<OutletsEntity> Outlets { get; set; }

        public UserEntity CreatorUser { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
    }

    /// <summary>
    /// 运单
    /// </summary>
    public class TransportDetailEntity : Entity<long>, ICreationAudited<UserEntity>
    {
        /// <summary>
        /// 路线名称
        /// </summary>
        public string RouteName { get; set; }

        public string Remarks { get; set; }

        public ICollection<OutletsEntity> Outlets { get; set; }

        public UserEntity CreatorUser { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}