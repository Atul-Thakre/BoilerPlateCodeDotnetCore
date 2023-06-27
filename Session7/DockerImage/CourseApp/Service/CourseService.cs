using CourseApp.Context;
using CourseApp.Exceptions;
using CourseApp.Models;
using CourseApp.Repository;

//prevalidation purpose
namespace CourseApp.Service
{
    public class CourseService : ICourseService
    {
        readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public bool AddCourse(Course course)
        {
            var courseExist = _courseRepository.GetCourseByName(course.CourseName);
            if (courseExist == null)
            {
                return _courseRepository.AddCourse(course); 
            }
            throw new CourseAlreadyExistsException($"Course with {course.CourseName} already Exist..!!!");
        }

        public List<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }

        public Course GetById(int id)
        {
            return _courseRepository.GetById1(id);
        }

        public object GetCourseByName(string courseName)
        {
            throw new NotImplementedException();
        }

        public void EditCourse1(Course course)
        {
            _courseRepository.EditCourse2(course);
        }
        public void DeleteCourseById(int courseId)
        {
            var course =_courseRepository.GetById1(courseId);
            var courseExist = _courseRepository.GetById1(courseId);
            if (courseExist!=null)
            {
                 _courseRepository.DeleteCourse(course);
            }
        }

        public void ShowDetailsOfCourse(int courseId)
        {
            var course = _courseRepository.GetById1(courseId);
            var courseExist = _courseRepository.GetById1(courseId);
            if (courseExist != null)
            {
                _courseRepository.ShowDetailsOfCourse(course);
            }
            
        }
    }
}
