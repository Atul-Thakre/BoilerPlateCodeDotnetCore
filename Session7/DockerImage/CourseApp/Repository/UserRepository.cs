using CourseApp.Context;
using CourseApp.Models;
using CourseApp.Service;


namespace CourseApp.Repository
{
    
    public class UserRepository : IUserRepository
    {

        CourseDbContext _courseDbContext;
        //All operation should done witn _courseDbContext instance add product, delete producut

        //Constructor
        public UserRepository(CourseDbContext courseDbContext)
        {
            _courseDbContext = courseDbContext;
        }

        public List<Course> GetAllCourses()
        {
            return _courseDbContext.Courses.ToList();
        }
    }
}
