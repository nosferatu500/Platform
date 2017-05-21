using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Data
{
    public enum Status
    {
        /// <summary>
        /// Status of the course/account "Consideration".
        /// </summary>
        Consideration = 1,

        /// <summary>
        /// Status of the course/account "Approved".
        /// </summary>
        Approved = 2,

        /// <summary>
        /// Status of the course/account "Rejected".
        /// </summary>
        Rejected = 3,

        /// <summary>
        /// Status of the course/account "Blocked".
        /// </summary>
        Blocked = 4
    }
}
