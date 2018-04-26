using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 邮件对象
    /// </summary>
    public class Email
    {
        /// <summary>
        /// 发件者地址
        /// </summary>
        public string FromAddr { get; set; }
        /// <summary>
        /// 收件人地址
        /// </summary>
        public string ToAddr { get; set; }
    }



}
