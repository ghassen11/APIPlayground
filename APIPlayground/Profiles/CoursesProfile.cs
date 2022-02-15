using APIPlayground.Models;
using AutoMapper;
using CourseLibrary.API.Entities;

namespace APIPlayground.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Course, CourseDto>();
        }

    }
}
