using CourseApp.Models;

namespace CourseApp.Service
{
    public interface ICourseService
    {
        public bool AddCourse(Course course);

        public List<Course> GetAllCourses();

        public Course GetById(int id);

        object GetCourseByName(string courseName);

        public void EditCourse1(Course course);
        void DeleteCourseById(int courseId);
        void ShowDetailsOfCourse(int courseId);
    }
}
