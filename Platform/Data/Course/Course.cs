using CoreEclipse.Data;

namespace Platform.Data.Course
{
    public class Course : BaseData
    {
        /// <summary>
        /// The description of the course.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The coast of the course.
        /// </summary>
        public float Coast { get; set; }
        /// <summary>
        /// The duration of the course.
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// The difficulty of the course.
        /// </summary>
        public Difficulty Difficulty { get; set; }
        /// <summary>
        /// The title of the course.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The author of the course.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The category of the course.
        /// </summary>
        public Categories Category { get; set; }
        /// <summary>
        /// Number of lessons in a course.
        /// </summary>
        public int Lessons { get; set; }
        /// <summary>
        /// The languages of the course.
        /// </summary>
        public Languages Language { get; set; }
        /// <summary>
        /// The rating of the course.
        /// </summary>
        public int Rating { get; set; }
        /// <summary>
        /// Approved status of the course.
        /// </summary>
        public Status CourseStatus { get; set; }

        /// <summary>
        /// Base constructor for initialize data.
        /// </summary>
        public Course()
        {
            Description = string.Empty;
            Coast = 0;
            Duration = string.Empty;
            Difficulty = Difficulty.Easy;
            Title = string.Empty;
            Author = string.Empty;
            Category = Categories.Photo;
            Lessons = 0;
            Language = Languages.Russian;
            Rating = 0;
            CourseStatus = Status.Consideration;
        }
    }
}
