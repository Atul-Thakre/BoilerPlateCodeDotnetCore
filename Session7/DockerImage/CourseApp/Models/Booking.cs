using CourseApp.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Models
{
    public class Booking
    {
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [Key]
        public int BookingId { get; set; }
        public string? CourseName { get; set; }
        public int CoursePrice { get; set; }
        public CourseCategory CourseCategory { get; set; }

    }
}
