using System.ComponentModel.DataAnnotations;
namespace LMS.Core.Entities;

public class Activity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    
    [Required]
    public int CourseModuleId { get; set; }
    public CourseModule? CourseModule { get; set; }
}
