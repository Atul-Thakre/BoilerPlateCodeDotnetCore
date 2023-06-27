using CourseApp.Context;
using CourseApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Repository
{
    public class CourseRepository : ICourseRepository
    {
        CourseDbContext _courseDbContext;
        //All operation should done witn _courseDbContext instance add product, delete producut

        //Constructor
        public CourseRepository(CourseDbContext courseDbContext)
        {
            _courseDbContext = courseDbContext;       
        }

        public bool AddCourse(Course course)
        {
            if (_courseDbContext.Courses.Any(p => p.CourseName == course.CourseName) == false)
            {
                _courseDbContext.Courses.Add(course);
            }

            return _courseDbContext.SaveChanges() == 1 ? true : false;      
        }

        public void DeleteCourse(Course course)
        {
            _courseDbContext.Remove(course);
            _courseDbContext.SaveChanges();
        }

        public void EditCourse2(Course course)
        {
            var existingCourse = _courseDbContext.Courses.Find(course.CourseId);

            if (existingCourse != null)
            {
                // Update the attributes of the existing course
                existingCourse.CourseName = course.CourseName;
                existingCourse.CoursePrice = course.CoursePrice;
                existingCourse.CourseCategory = course.CourseCategory;

                // Save the changes to the database
                _courseDbContext.SaveChanges();
            }
        }

        public List<Course> GetAllCourses()
        {
            return _courseDbContext.Courses.ToList();
        }

       

        public Course GetById1(int id)
        {
            Course course =_courseDbContext.Courses.FirstOrDefault(u => u.CourseId == id);
            
            return course;
        }

        public Course GetCourseByName(string courseName)
        {
            return _courseDbContext.Courses.Where(p => p.CourseName == courseName).FirstOrDefault();
        }

        public Course ShowDetailsOfCourse(Course course)
        {
            var courseDetail = _courseDbContext.Courses
            .Where(c => c.CourseId == course.CourseId)
            .Select(c => new Course
            {
                CourseId = c.CourseId,
                CourseName = c.CourseName,
                // Map other properties from the Course entity as needed
            })
            .FirstOrDefault();
            return courseDetail;
        }
    }
}
