using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class StudCourse
{
    [Key]
    [Column(Order = 0)]
    [ForeignKey("Crs")]
    public int CrsID { get; set; }

   
    [ForeignKey("St")]
    public int StId { get; set; }

    public int? Grade { get; set; }

    public  Course Crs { get; set; } 

    public  Student St { get; set; }
}

