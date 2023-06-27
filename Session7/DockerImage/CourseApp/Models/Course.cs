using CourseApp.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required(ErrorMessage ="Please enter Name of Course")]
        public string CourseName { get; set; }
        [Required]
        public int CoursePrice { get; set; }
        [Required(ErrorMessage = "Please enter Name of Course")]
        public CourseCategory CourseCategory { get; set; }
       
    }
}
