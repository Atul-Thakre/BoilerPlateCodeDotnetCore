using CourseApp.Models;

namespace CourseApp.Service
{
    public interface IBookingService
    {
        void BookCourse(int courseId, int userId);
        void CancelCourse(int bookingId);
        List<Course> GetAllCourses();
    }
}
