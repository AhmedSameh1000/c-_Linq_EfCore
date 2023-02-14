using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public partial class Context : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("App.json").Build();
        var connectionString = configuration.GetSection("string").Value;
        optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<Course> courses { get; set; }
    //public DbSet<Department> departments { get; set; }
    //public DbSet<InsCourse> inscourses { get; set; }
    ////public DbSet<Instructor> instructors { get; set; }
    //public DbSet<StudCourse> studCourses { get; set; }
    //public DbSet<Student> students { get; set; }    
    public DbSet<Topic> topics { get; set; }

}
