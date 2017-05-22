using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEclipse.Account;

namespace Platform.Data.Course.Lesson
{
    public class Lesson : BaseData
    {
        /// <summary>
        /// Name of lesson.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Duration of lesson.
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// Collection of link for work with remote services.
        /// </summary>
        public Dictionary<Links, string> Link { get; set; }
        /// <summary>
        /// Description of lesson.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Base constructor for inizialize data.
        /// </summary>
        public Lesson()
        {
            Title = string.Empty;
            Duration = string.Empty;
            Link = new Dictionary<Links, string>();
            Description = string.Empty;
        }
    }
}
