using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


public partial class Instructor
{
    public int ID { get; set; }

    public string? InsName { get; set; }

    public string? InsDegree { get; set; }

    public decimal? Salary { get; set; }
    [ForeignKey("Dept")]
    public int? DeptId { get; set; }

    public List<Department> Departments { get; set; }

    public Department? Dept { get; set; }

    public List<InsCourse> InsCourses { get; set; }
}
