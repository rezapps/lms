using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Core.Dtos;

public class StudentDto : UserDto
{
    public string FullName { get { return Name + " " + LastName; } }
    public DateTime EnrollmentDate { get; set; } = DateTime.Now;
    public EnrollmentDto? Enrollment { get; set; }
}
