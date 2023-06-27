using CourseApp.Context;
using CourseApp.Migrations;
using CourseApp.Models;

namespace CourseApp.Repository
{
    public class BookingRepository:IBookingRepository
    {
        CourseDbContext _courseDbContext;
        //All operation should done witn _courseDbContext instance add product, delete producut

        //Constructor
        public BookingRepository(CourseDbContext courseDbContext)
        {
            _courseDbContext = courseDbContext;
        }
       

        public void BookCourse(Booking booking)
        {
            // Add the booking to the DbContext
            _courseDbContext.Bookings.Add(booking);
            _courseDbContext.SaveChanges();
        }


        public void CancelCourse(int bookingId)
        {
            // Find the booking with the specified bookingId
            Booking booking = _courseDbContext.Bookings.FirstOrDefault(b => b.BookingId == bookingId);

            if (booking != null)
            {
                // Remove the booking from the DbContext
                _courseDbContext.Bookings.Remove(booking);
                _courseDbContext.SaveChanges();
            }
        }

        public List<Course> GetAllCourses()
        {
            return _courseDbContext.Courses.ToList();
        }
    }
}
