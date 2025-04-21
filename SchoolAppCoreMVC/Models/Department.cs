using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAppCoreMVC.Models;

public partial class Department
{
    [Key]
    [Column("DepartmentID")]
    public int DepartmentId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Budget { get; set; }

    public DateOnly StartDate { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
