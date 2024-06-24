using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Core.Dtos;

public class CourseDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public double Credits { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public int TeacherId { get; set; }
    public List<EnrollmentDto>? Enrollments { get; set; }
    public ICollection<CourseModuleDto>? CourseModules { get; set; }
    public TeacherDto? Teacher { get; set; }
}
