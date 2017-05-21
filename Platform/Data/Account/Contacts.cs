using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Data.Account
{
    public enum Contacts
    {
        /// <summary>
        /// Link to VKontakte account.
        /// </summary>
        Vk = 1,

        /// <summary>
        /// Link to  Odnoklassniki account.
        /// </summary>
        Ok = 2,

        /// <summary>
        /// Link to Instagram account.
        /// </summary>
        Instagram = 3,

        /// <summary>
        /// Email link.
        /// </summary>
        Email = 4,

        /// <summary>
        /// Phone number.
        /// </summary>
        Telephone = 5
    }
}
