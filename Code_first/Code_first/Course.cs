using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Course
{
    public int ID { get; set; }
    [MaxLength(20),Required]
    public string? CrsName { get; set; }

    public int? Duratuin { get; set; }
    [ForeignKey("Top")]
    public int? TopId { get; set; }

    public  List<InsCourse> InsCourses { get; set; }

    public  List<StudCourse> StudCourses { get; set; }
    public  Topic? Top { get; set; }
}

