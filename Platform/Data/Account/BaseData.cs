using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Data.Account
{
    public class BaseData
    {
        /// <summary>Key in table.</summary>
        [Key]
        public long ID { get; set; }

        /// <summary>Create date.</summary>
        public DateTime CreateAt { get; set; }

        /// <summary>Last update date.</summary>
        public DateTime UpdateAt { get; set; }

        /// <summary>Marker that field is deleted</summary>
        public bool Deleted { get; set; }
    }
}
