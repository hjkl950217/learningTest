using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
    public class EmailDAL : IEmailService
    {
        public bool SendEmail( Email email )
        {
            return true;
        }
    }
}
