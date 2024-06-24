using System.ComponentModel.DataAnnotations;
namespace LMS.Core.Entities;

public class CourseModule
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Description { get; set; }
    public int CourseId { get; set; }
    public Course? Course { get; set; }
    public ICollection<Activity>? Activities { get; set; }

}
