using CourseAppWebApi.Context;
using CourseAppWebApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CourseAppWebApi.Services
{
    public class CourseService : ICourseService
    {
        readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        

        public void AddCourse(Course course)
        {
             _courseRepository.AddCourse(course);
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.DeleteCourse(id);
        }

       

        public async Task<List<Course>> GetAllCourses()
        {
            return await _courseRepository.GetAllCourses();
        }

       

        public async Task<Course> GetCourseById(int id)
        {
            return await _courseRepository.GetCourseById(id);
        }





       
    }
}
