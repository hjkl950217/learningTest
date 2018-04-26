using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IManufacturerRequestService
    {



        /// <summary>
        /// 获取所有的ManfactureRequestIn请求
        /// </summary>
        /// <returns></returns>
        List<ManfactureRequestOut> GetAllManfactureRequest( );

        /// <summary>
        /// 通过请求ID获取ManfactureRequestOut请求
        /// </summary>
        /// <param name="requestID"></param>
        /// <returns></returns>
        ManfactureRequestOut GetManfactureRequest( int requestID );

        /// <summary>
        /// 添加ManfactureRequest请求
        /// </summary>
        /// <param name=""requestIn>要写入的请求信息</param>
        /// <returns></returns>
        bool AddManfactureRequest( ManfactureRequestIn requestIn);

        /// <summary>
        /// 添加ManfactureRequest请求
        /// </summary>
        /// <param name=""requestIn>要写入的请求信息</param>
        /// <returns></returns>
        Task<bool> AddManfactureRequestAsync( ManfactureRequestIn requestIn );

        /// <summary>
        /// 审批ManfactureRequest请求
        /// </summary>
        /// <param name="requestID">需要审批的ID</param>
        /// <returns></returns>
        bool AuditManfactureRequest( int requestID );

        /// <summary>
        /// 审批ManfactureRequest请求
        /// </summary>
        /// <param name="requestID">需要审批的ID集合</param>
        /// <returns></returns>
        bool AuditManfactureRequest( List<int> requestIDList );
    }


}
