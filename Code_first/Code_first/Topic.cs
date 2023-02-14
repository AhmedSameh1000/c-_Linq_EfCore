using System;
using System.Collections.Generic;


public partial class Topic
{
    public int ID { get; set; }

    public string? TopName { get; set; }

    public  List<Course> Courses { get; set; }
}

