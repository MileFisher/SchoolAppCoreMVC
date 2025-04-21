using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAppCoreMVC.Models;

public partial class Course
{
    [Key]
    [Column("CourseID")]
    public int CourseId { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = null!;

    public int Credits { get; set; }

    [Column("DepartmentID")]
    public int? DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Courses")]
    public virtual Department? Department { get; set; }

    [InverseProperty("Course")]
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
