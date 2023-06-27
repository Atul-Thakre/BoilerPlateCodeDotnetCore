using AutoMapper;
using CourseAppWebApi.Context;
using Microsoft.EntityFrameworkCore;

namespace CourseAppWebApi.Repository
{
    public class CourseRepository : ICourseRepository
    {
        readonly AppDbContext _courseDbContext;
        readonly IMapper _mapper;

        public CourseRepository(AppDbContext courseDbContext, IMapper mapper)
        {
            _courseDbContext = courseDbContext;
            _mapper = mapper;
        }

        public void AddCourse(Course course)
        {
            _courseDbContext.Courses.Add(course);
            _courseDbContext.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var c = _courseDbContext.Courses.Find(id);

            _courseDbContext.Remove(c);
            _courseDbContext.SaveChanges();
        }

     

        public async Task<List<Course>> GetAllCourses()
        {
            return await _courseDbContext.Courses.ToListAsync();
        }

        public async Task<Course> GetCourseById(int id)
        {
            return await _courseDbContext.Courses.Where(c => c.CourseId == id).FirstOrDefaultAsync();
        }
    }
}