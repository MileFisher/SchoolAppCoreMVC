using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAppCoreMVC.Models;

[Table("tblUser")]
[Index("Username", Name = "UQ__tblUser__536C85E435D9529A", IsUnique = true)]
public partial class TblUser
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    public string Username { get; set; } = null!;

    [StringLength(50)]
    public string Password { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;
}
