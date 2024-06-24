using System.ComponentModel.DataAnnotations;
namespace LMS.Core.Entities;

public class Document
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    [Required]
    public int CreatedById { get; set; }
    public int CourseId { get; set; }

    // Navigation Properties
    public User? CreatedBy { get; set; }
    public Course? Course { get; set; }
    public bool AccessibleByCourseStudents { get; set; }
    public ICollection<DocumentAccess>? DocumentAccesses { get; set; }
}
