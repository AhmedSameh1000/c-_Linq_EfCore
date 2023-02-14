using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Student
{
    public int Id { get; set; }

    public string? StFname { get; set; }

    public string? StLname { get; set; }

    public string? StAddress { get; set; }

    public int? StAge { get; set; }

    [ForeignKey("Dept")]
    public int? DeptId { get; set; }

    [ForeignKey("StSuperriolation")]
    public int? StSuper { get; set; }

    public Department? Dept { get; set; }

    public List<Student>? Super_student { get; set; }

    public Student? StSuperriolation { get; set; }

    public List<StudCourse>? Student_cources { get; set; } 
}




