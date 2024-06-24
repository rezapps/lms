using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Core.Entities;

namespace LMS.Core.Dtos;
public class EnrollmentDto
{
    public int Id { get; set; }
    public int Grade { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public CourseDto? Course { get; set; }
    public StudentDto? Student { get; set; }
}
