using CourseApp.Models;

namespace CourseApp.Repository
{
    public interface ICourseRepository
    {
        bool AddCourse(Course course);
        void DeleteCourse(Course course);
        void EditCourse2(Course course);
        List<Course> GetAllCourses();
     
        Course GetById1(int id);

        public Course GetCourseByName(string courseName);
        Course ShowDetailsOfCourse(Course course);
    }
}
