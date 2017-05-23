using Newtonsoft.Json;
using Platform.Data.Account.Protection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using CoreEclipse.Account.Protection;
using CoreEclipse.Data;

namespace Platform.Data.Account
{
    public class Account : BaseData
    {
        /// <summary>
        /// Access token of user.
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// Name of user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Email of user.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The user password hash.
        /// </summary>
        public long PasswordHash { get; set; }
        /// <summary>
        /// The photo of user.
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        ///The level of user rights.
        /// </summary>
        public AccessRights Rights { get; set; }
        /// <summary>
        /// Wish list of student.
        /// </summary>
        /// 
        [NotMapped]
        public Dictionary<long, string> WishList { get; set; }
        /// <summary>
        /// Is indicates whether the account is banned.
        /// </summary>
        public bool IsBanned { get; set; }

        /// <summary>
        /// Access keys for work with protection data.
        /// </summary>
        [JsonIgnore]
        public AccessKeys Keys => new AccessKeys()
        {
            ID = ID,
            AccessToken = AccessToken
        };

        /// <summary>
        /// Base class for initialize data.
        /// </summary>
        public Account()
        {
            Name = string.Empty;
            Email = string.Empty;
            PasswordHash = -1;
            Photo = String.Empty;
            Rights = AccessRights.Student;
            WishList = new Dictionary<long, string>();
            IsBanned = false;
        }
    }
}
