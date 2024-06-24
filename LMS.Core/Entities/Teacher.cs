using System.ComponentModel.DataAnnotations;
namespace LMS.Core.Entities;

public class Teacher : User
{
    public ICollection<Course>? Courses { get; set; }
}
