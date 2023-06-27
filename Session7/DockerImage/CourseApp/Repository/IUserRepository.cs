using CourseApp.Models;

namespace CourseApp.Repository
{
    public interface IUserRepository
    {
        List<Course> GetAllCourses();
    }
}
