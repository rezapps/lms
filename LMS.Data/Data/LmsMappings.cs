using AutoMapper;
using LMS.Core.Entities;
using LMS.Core.Dtos;

namespace LMS.Data.Data;
public class LmsMappings : Profile
{
    public LmsMappings()
    {   
        CreateMap<Enrollment, EnrollmentDto>();
        CreateMap<CourseModule, CourseModuleDto>();
        CreateMap<User, UserDto>();
        CreateMap<Teacher, TeacherDto>();
        CreateMap<Activity, ActivityDto>();
        CreateMap<Document, DocumentDto>();
        CreateMap<Student, StudentDto>();
        
        // CreateMap<Enrollment, StudentDto>()
        //     .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.StudentId))
        //     .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Student.Name + " " + src.Student.LastName));

        CreateMap<Course, CourseDto>()
            .ForMember(dest => dest.Teacher, opt => opt.MapFrom(src => src.Teacher))
            .ForMember(dest => dest.Enrollments, opt => opt.MapFrom(src => src.Enrollments != null ? src.Enrollments.Select(e => e.Student).ToList() : null));

    }
}
