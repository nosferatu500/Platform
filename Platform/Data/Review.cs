using CoreEclipse.Account;

namespace Platform.Data
{
    public class Review : BaseData
    {
        /// <summary>
        /// ID author of review.
        /// </summary>
        public long AuthorId { get; set; }
        /// <summary>
        /// Course rating.
        /// </summary>
        public int CourseRating { get; set; }
        /// <summary>
        /// Teacher rating.
        /// </summary>
        public int TeacherRating { get; set; }
        /// <summary>
        /// Review text.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Review rating.
        /// </summary>
        public int ReviewRating { get; set; }

        /// <summary>
        /// Base constructor for initialize data.
        /// </summary>
        public Review()
        {
            AuthorId = 0;
            CourseRating = 5;
            TeacherRating = 5;
            Comment = string.Empty;
            ReviewRating = 0;
        }
    }
}
