using AutoMapper;
using CourseAppWebApi.Context;
using CourseAppWebApi.DTO.CourseDto;
using CourseAppWebApi.DTO.User;

namespace CourseAppWebApi.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Course, GetAllCoursesDto>().ReverseMap();
            CreateMap<Course,AddCourseDto>().ReverseMap();
            CreateMap<APIUser, ApiUserDto>().ReverseMap();
            

        }
    }
}
