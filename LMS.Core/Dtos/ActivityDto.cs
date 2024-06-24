using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Core.Dtos;

public class ActivityDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    
    public int CourseModuleId { get; set; }
    public CourseModuleDto? CourseModule { get; set; }
}
