using CourseAppWebApi.Context;
using Microsoft.AspNetCore.Mvc;

namespace CourseAppWebApi.Services
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        void DeleteCourse(int id);
        Task<List<Course>> GetAllCourses();

        //  Task< List<Course>> GetAllCourses();
        Task<Course> GetCourseById(int id);
    }
}