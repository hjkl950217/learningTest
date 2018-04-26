using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;


namespace Model
{
    public static class Data
    {
        /// <summary>
        /// 模拟数据
        /// </summary>
        public static List<ManfactureRequest> DataList { get; set; } = new List<ManfactureRequest>( )
        {
            new ManfactureRequest( ) { ItemID = "KIUCIUI",SellerID = "BHD3",RequestID = 14352},
            new ManfactureRequest( ) { ItemID = "K89485D",SellerID = "BHD8",RequestID = 84512}
        };
    }


}
