using System.ComponentModel.DataAnnotations;
namespace LMS.Core.Entities;

public class Student : User
{
    public DateTime EnrollmentDate { get; set; }
    public Enrollment? Enrollment { get; set; }
}
