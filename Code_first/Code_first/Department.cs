using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Department
{
    public int ID { get; set; }

    public string? DeptName { get; set; }

    public string? DeptDesc { get; set; }

    public string? DeptLocation { get; set; }

    public int? DeptManager { get; set; }

    public DateTime? ManagerHiredate { get; set; }   
}

