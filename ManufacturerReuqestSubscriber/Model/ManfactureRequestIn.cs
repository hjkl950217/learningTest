using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class ManfactureRequestIn
    {

        [Required]
        [StringLength( 10 )]
        public string SellerID { get; set; }

        public string ItemID { get; set; }

        /// <summary>
        /// 获取哈希值，当值为0时说明数据中没有值
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode( )
        {
            if( this.SellerID == null && this.ItemID == null ) return 0;

            return base.GetHashCode( );
        }

    }



}
