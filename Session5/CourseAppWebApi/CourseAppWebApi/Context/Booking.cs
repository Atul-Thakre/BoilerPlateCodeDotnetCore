using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseAppWebApi.Context
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }

        [ForeignKey("Course"]
        public int CourseId { get; set; }
        public Course course { get; set; }


        public int UserId { get; set; } //iska kuch karna padega
        
       
    }
}
