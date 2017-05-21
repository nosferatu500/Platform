using Platform.Data.Account.Protection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Data.Account
{
    public class User : Account
    {
        /// <summary>
        /// Money in the account of the student.
        /// </summary>
        /// <returns></returns>
        public double Money { get; set; }

        /// <summary>
        /// Base constructor for initialize data.
        /// </summary>
        public User()
        {
            Rights = AccessRights.Student;
            Money = 0.0;
        }
    }
}
