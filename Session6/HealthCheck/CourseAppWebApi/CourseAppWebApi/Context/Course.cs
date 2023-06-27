using System.ComponentModel.DataAnnotations;

namespace CourseAppWebApi.Context
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }

    }
}
