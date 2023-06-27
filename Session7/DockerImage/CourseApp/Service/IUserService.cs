using CourseApp.Models;

namespace CourseApp.Service
{
    public interface IUserService
    {
        List<Course> GetAllCourses();
    }
}
