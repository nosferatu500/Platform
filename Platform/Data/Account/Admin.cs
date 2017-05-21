using Platform.Data.Account.Protection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Data.Account
{
    public class Admin : Account
    {
        /// <summary>
        /// Base class for initialize data.
        /// </summary>
        public Admin()
        {
            Rights = AccessRights.Admin;
        }
    }
}
