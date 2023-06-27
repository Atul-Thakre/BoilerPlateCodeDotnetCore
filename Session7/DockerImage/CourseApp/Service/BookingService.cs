using CourseApp.Models;
using CourseApp.Repository;

namespace CourseApp.Service
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public void BookCourse(int courseId, int userId)
        {
            // Retrieve course details from CourseRepository and user details from UserRepository
            // Perform any necessary validation or processing
            // Create a booking object
            Booking booking = new Booking
            {
               
                UserId = userId,
                CourseName = "CourseName",
                CoursePrice = 100
            };

            _bookingRepository.BookCourse(booking);
        }

        public void CancelCourse(int bookingId)
        {
            _bookingRepository.CancelCourse(bookingId);
        }

        public List<Course> GetAllCourses()
        {
            return _bookingRepository.GetAllCourses();
        }
    }

}
