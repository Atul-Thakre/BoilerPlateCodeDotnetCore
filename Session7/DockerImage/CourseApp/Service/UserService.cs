using CourseApp.Models;
using CourseApp.Repository;

namespace CourseApp.Service
{
    public class UserService : IUserService
    {

        readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<Course> GetAllCourses()
        {
             return _userRepository.GetAllCourses();
        }
    }
}
