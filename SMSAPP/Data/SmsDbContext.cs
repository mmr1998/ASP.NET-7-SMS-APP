using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SMSAPP.Data;

public partial class SmsDbContext : DbContext
{
    public SmsDbContext(DbContextOptions<SmsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Lecturer> Lecturers { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasIndex(e => e.CourseCode, "UQ__Courses__FC00E00080F33E42").IsUnique();

            entity.Property(e => e.CourseCode).HasMaxLength(8);
            entity.Property(e => e.CourseName).HasMaxLength(450);
        });

        modelBuilder.Entity<Lecturer>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(4000);
            entity.Property(e => e.FirstName).HasMaxLength(450);
            entity.Property(e => e.LastName).HasMaxLength(450);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(4000);
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FirstName).HasMaxLength(450);
            entity.Property(e => e.LastName).HasMaxLength(450);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
