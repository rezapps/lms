using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Core.Dtos;

public class TeacherDto : UserDto
{
    public string FullName { get { return Name + " " + LastName; } }
    public ICollection<CourseDto>? Courses { get; set; }
}
