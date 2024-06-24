using System.ComponentModel.DataAnnotations;
namespace LMS.Core.Entities;

public class Enrollment
{
    [Key]
    public int Id { get; set; }
    [Required]
    [Range(1,5)]
    public int Grade { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public Course? Course { get; set; }
    public Student? Student { get; set; }
}
