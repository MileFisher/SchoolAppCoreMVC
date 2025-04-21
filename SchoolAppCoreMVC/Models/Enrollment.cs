using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAppCoreMVC.Models;

public partial class Enrollment
{
    [Key]
    [Column("EnrollmentID")]
    public int EnrollmentId { get; set; }

    [Column("CourseID")]
    public int? CourseId { get; set; }

    [Column("StudentID")]
    public int? StudentId { get; set; }

    [Column(TypeName = "decimal(3, 2)")]
    public decimal? Grade { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("Enrollments")]
    public virtual Course? Course { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("Enrollments")]
    public virtual Student? Student { get; set; }
}
