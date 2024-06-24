using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Core.Entities;

namespace LMS.Core.Dtos;
public class DocumentDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateTime CreatedAt { get; set; }
    public TeacherDto? CreatedByTeacher { get; set; }
    public StudentDto? CreatedByStudent { get; set; }
    public bool AccessibleByCourseStudents { get; set; }
    public ICollection<DocumentAccessDto>? DocumentAccesses { get; set; }
}
