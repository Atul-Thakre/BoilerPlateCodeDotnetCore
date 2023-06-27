using AutoMapper;
using CourseAppWebApi.Context;
using CourseAppWebApi.DTO.CourseDto;
//using CourseAppWebApi.Context.Course;
using CourseAppWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace CourseAppWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        readonly ICourseService _courseService;
        readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }


        [Route("GetAllCourses")]
        [HttpGet]
        public async Task<ActionResult> GetAllCourses()
        {
            List<Course> allCourse = await _courseService.GetAllCourses();
            return Ok(allCourse);
        }

        [Route("GetCourseById")]
        [HttpGet]
        public async Task<ActionResult> GetCourse(int id)  //along side async we have to write Task<>
        {
            Course course = await _courseService.GetCourseById(id);
            return Ok(course);
        }


        [Route("AddCourse")]
        [HttpPost]
        public async Task<ActionResult> AddCourse(AddCourseDto addCourseDto)
        {
            var course = _mapper.Map<Course>(addCourseDto);
            _courseService.AddCourse(course);
            return CreatedAtAction("GetCourse", new { id = course.CourseId }, course);
        }

        
        [HttpDelete("{id}")]
        public ActionResult DeleteCourse(int id)
        {
             _courseService.DeleteCourse(id);
            return Ok();


        }



    }
}




