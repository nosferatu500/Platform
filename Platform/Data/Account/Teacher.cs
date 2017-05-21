using Platform.Data.Account.Protection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Data.Account
{
    public class Teacher : Account
    {
        /// <summary>
        /// Collection of link for contact with teacher.
        /// </summary>
        [NotMapped]
        public Dictionary<Contacts, string> Contacts { get; set; }
        /// <summary>
        /// Information about the teacher.
        /// </summary>
        public string About { get; set; }
        /// <summary>
        /// The rating of teacher.
        /// </summary>
        public double Rating { get; set; }
        /// <summary>
        /// Approved status of the teacher.
        /// </summary>
        public Status TeacherStatus { get; set; }

        /// <summary>
        /// Base constructor for initialize data.
        /// </summary>
        public Teacher()
        {
            Rights = AccessRights.Teacher;
            Contacts = new Dictionary<Contacts, string>();
            About = string.Empty;
            Rating = 0.0;
            TeacherStatus = Status.Consideration;
        }
    }
}
