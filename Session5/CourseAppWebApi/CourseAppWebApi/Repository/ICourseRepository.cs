using CourseAppWebApi.Context;
using Microsoft.AspNetCore.Mvc;

namespace CourseAppWebApi.Repository
{
    public interface ICourseRepository
    {
        void AddCourse(Course course);
        void DeleteCourse(int id);
       
        Task< List<Course>> GetAllCourses();
        Task<Course> GetCourseById(int id);
    }
}
