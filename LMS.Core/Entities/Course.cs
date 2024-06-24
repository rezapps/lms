using System.ComponentModel.DataAnnotations;
namespace LMS.Core.Entities;
public class Course
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Range(1.0,15.0)]
    public double Credits { get; set; }
    [DataType(DataType.Date)]
    public DateTime Start { get; set; }
    [DataType(DataType.Date)]
    public DateTime End { get; set; }

    public int TeacherId { get; set; }

    public Teacher? Teacher { get; set; }
    public ICollection<Enrollment>? Enrollments { get; set; }
    public ICollection<CourseModule>? CourseModules { get; set; }

}
