using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Data.Account.Protection
{
    public enum AccessRights
    {
        /// <summary>
        /// Admin rights.
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Teacher rights.
        /// </summary>
        Teacher = 2,

        /// <summary>
        /// Student rights.
        /// </summary>
        Student = 3
    }
}
