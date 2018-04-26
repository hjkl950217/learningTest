using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using System.IO;

using IDAL;
using Model;

namespace DAL
{
 /**
 *                             _ooOoo_
 *                            o8888888o
 *                            88" . "88
 *                            (\ -_- \)
 *                            O\  =  \O
 *                         ____/`---'\____
 *                       .'  \\\\    \\\  `.
 *                      /  \\|||  :  |||\\  \
 *                     /  _||||| -:- |||||-  \
 *                     |   | \\\  -  /// |   |
 *                     | \_|  ''\---/''  |   |
 *                     \  .-\__  `-`  ___/-. /
 *                   ___`. .'  /--.--\  `. . __
 *                ."" '<  `.___\_<|>_/___.'  >'"".
 *               | | :  `- \`.;`\ _ /`;.`/ - ` : | |
 *               \  \ `-.   \_ __\ /__ _/   .-` /  /
 *          ======`-.____`-.___\_____/___.-`____.-'======
 *                             `=---='
 *          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 *                     佛祖保佑        永无BUG
 *            佛曰:
 *                   写字楼里写字间，写字间里程序员；
 *                   程序人员写程序，又拿程序换酒钱。
 *                   酒醒只在网上坐，酒醉还来网下眠；
 *                   酒醉酒醒日复日，网上网下年复年。
 *                   但愿老死电脑间，不愿鞠躬老板前；
 *                   奔驰宝马贵者趣，公交自行程序员。
 *                   别人笑我忒疯癫，我笑自己命太贱；
 *                   不见满街漂亮妹，哪个归得程序员？
 */
    public class ManufacturerRequestDAL : IManufacturerRequestService
    {



        #region IManufacturerRequestService实现
        /// <summary>
        /// 添加新请求到数据库
        /// </summary>
        /// <param name="requestIn"></param>
        /// <returns></returns>
        public bool AddManfactureRequest( ManfactureRequestIn requestIn )
        {
            //判断是否已存在
            var findResult = Data.DataList
                .Find( t => t.SellerID == requestIn.SellerID && t.ItemID == requestIn.ItemID );
            if( findResult != null ) return true;
            /*这里返回true是让客户端不管请求多少次，都会是一样的效果*/

            //添加
            int newID = Data.DataList
                .OrderByDescending( t => t.RequestID )
                .FirstOrDefault( )
                .RequestID++;

            Data.DataList.Add( new ManfactureRequest( )
            {
                RequestID = newID ,
                SellerID = requestIn.SellerID ,
                ItemID = requestIn.ItemID
            } );

            return true;
        }

        /// <summary>
        /// 添加新请求到数据库
        /// </summary>
        /// <param name="requestIn"></param>
        /// <returns></returns>
        public Task<bool> AddManfactureRequestAsync( ManfactureRequestIn requestIn )
        {
            //判断是否已存在
            var findResult = Data.DataList
                .Find( t => t.SellerID == requestIn.SellerID && t.ItemID == requestIn.ItemID );
            if( findResult != null ) return Task.Run( ( ) => true );
            /*(async)这里返回true是让客户端不管请求多少次，都会是一样的效果
             * 
             */

          

            #region 异步添加并返回
            try
            {
               var result=  Task.Factory.StartNew( ( ) =>
                 {
                     int newID = Data.DataList
                     .OrderByDescending( t => t.RequestID )
                     .FirstOrDefault( )
                     .RequestID+1;

                     Data.DataList.Add( new ManfactureRequest( )
                     {
                         RequestID = newID ,
                         SellerID = requestIn.SellerID ,
                         ItemID = requestIn.ItemID
                     } );

                     return true;
                 } );

                //返回
                return result;
            }
            catch( Exception )
            {

                throw;
            }


            #endregion


        }

        /// <summary>
        /// 审批请求
        /// </summary>
        /// <param name="requestID"></param>
        /// <returns></returns>
        public bool AuditManfactureRequest( int requestID )
        {
            var request = Data.DataList.Find( t => t.RequestID == requestID );
            if( request == null ) return true;
            //todo:这里还需要思考下，没有找到有两种可能：
            /*1.本来就没有
             *2.已经审批过了，已经移除了，数据还没有返回到客户端，
             * 
             */

            //模拟耗时操作-审批验证操作
            Thread.Sleep( 1 * 1000 );
            try
            {
                Data.DataList.RemoveAll( t => t.RequestID == requestID );

                return true;
            }
            catch( Exception )
            {

                return false;
            }




        }

        /// <summary>
        /// 审批请求
        /// </summary>
        /// <param name="requestIDList"></param>
        /// <returns></returns>
        public bool AuditManfactureRequest( List<int> requestIDList )
        {

            var request = ( from a in Data.DataList
                            where requestIDList.Exists( t => t == a.RequestID )
                            select a
                            )
                            .ToList( );

            if( request.Count == 0 ) return false;
            //和审批单个一样的，两种可能怎么处理没有想好
            /*
             *
             */

            //模拟耗时操作-审批验证操作
            var result = request.ToList( );
            for( int i = 0 ; i < result.Count ; i++ )
            {
                //为避免结果中的引用重复问题，改用for
                Data.DataList.Remove( result[ i ] );
            }
            return true;

        }



        /// <summary>
        /// 通过一个GUID获取请求信息
        /// </summary>
        /// <param name="requestID"></param>
        /// <returns></returns>
        public ManfactureRequestOut GetManfactureRequest( int requestID )
        {
            var result = ( from a in Data.DataList
                           where a.RequestID == requestID
                           select new ManfactureRequestOut( )
                           {
                               SellerID = a.SellerID ,
                               ItemID = a.ItemID ,
                               RequestID = a.RequestID
                           } )
                         .FirstOrDefault( );

            return result;
        }

        /// <summary>
        /// 获取所有请求信息
        /// </summary>
        /// <returns></returns>
        public List<ManfactureRequestOut> GetAllManfactureRequest( )
        {


            return Data.DataList
                .Select( t => new ManfactureRequestOut( )
                {
                    SellerID = t.SellerID ,
                    ItemID = t.ItemID ,
                    RequestID = t.RequestID
                } )
                .ToList( );
        }


        #endregion

    }


}
