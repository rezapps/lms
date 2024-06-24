using Microsoft.EntityFrameworkCore;
using LMS.Core.Entities;

namespace LMS.Data.Data;

public class LmsContext : DbContext
{
    public LmsContext(DbContextOptions<LmsContext> options)
        : base(options)
    {
    }

    public DbSet<Course> Course { get; set; } = default!;
    public DbSet<CourseModule> CourseModule { get; set; } = default!;
    public DbSet<Activity> Activity { get; set; } = default!;
    public DbSet<Enrollment> Enrollment { get; set; } = default!;
    public DbSet<Teacher> Teacher { get; set; } = default!;
    public DbSet<Student> Student { get; set; } = default!;
    public DbSet<Document> Document { get; set; } = default!;
    public DbSet<User> User { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>()
            .HasMany(c => c.CourseModules)
            .WithOne(cm => cm.Course)
            .HasForeignKey(cm => cm.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Course>()
            .HasMany(c => c.Enrollments)
            .WithOne(e => e.Course)
            .HasForeignKey(e => e.CourseId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Role)
                .IsRequired()
                .HasMaxLength(50);
            entity.HasMany(e => e.Documents)
                .WithOne(d => d.CreatedBy)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Cascade);
        });


        modelBuilder.Entity<CourseModule>()
            .HasMany(cm => cm.Activities)
            .WithOne(a => a.CourseModule)
            .HasForeignKey(a => a.CourseModuleId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.Enrollment)
            .WithOne(e => e.Student)
            .HasForeignKey<Enrollment>(e => e.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Teacher>()
            .HasMany(t => t.Courses)
            .WithOne(c => c.Teacher)
            .HasForeignKey(c => c.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Document>()
            .HasOne(d => d.CreatedBy)
            .WithMany()
            .HasForeignKey(d => d.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DocumentAccess>()
            .HasKey(uda => new { uda.UserId, uda.DocumentId });

        modelBuilder.Entity<DocumentAccess>()
            .HasOne(uda => uda.Document)
            .WithMany(d => d.DocumentAccesses)
            .HasForeignKey(uda => uda.DocumentId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<User>()
            .HasDiscriminator<string>("Role")
            .HasValue<Teacher>("Teacher")
            .HasValue<Student>("Student");

        base.OnModelCreating(modelBuilder);
    }
}
