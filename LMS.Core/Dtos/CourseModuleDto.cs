using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Core.Dtos;

public class CourseModuleDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int CourseId { get; set; }
    public CourseDto? Course { get; set; }
    public ICollection<ActivityDto>? Activities { get; set; }
}
