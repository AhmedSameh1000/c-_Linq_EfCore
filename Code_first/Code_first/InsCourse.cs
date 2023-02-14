using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class InsCourse
{
    [Key]
    [Column(Order = 0)]
    [ForeignKey("Ins")]
    public int InsId { get; set; }

    
    [ForeignKey("Crs")]
    public int CrsId { get; set; }

    public string? Evaluation { get; set; }

    public Course Crs { get; set; }

    public  Instructor Ins { get; set; }
}
