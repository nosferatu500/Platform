﻿using CoreEclipse.Data;

namespace Platform.Data.Course.Lesson
{
    public class Homework : BaseData
    {
        /// <summary>
        /// Homework author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Homework description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Base constructor for inizialize data.
        /// </summary>
        public Homework()
        {
            Author = string.Empty;
            Description = string.Empty;
        }
    }
}
