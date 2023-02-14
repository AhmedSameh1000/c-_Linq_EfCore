﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Codefirst.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CrsName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Duratuin")
                        .HasColumnType("int");

                    b.Property<int?>("TopId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TopId");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DeptDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeptManager")
                        .HasColumnType("int");

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InstructorID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ManagerHiredate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("InsCourse", b =>
                {
                    b.Property<int>("InsId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<string>("Evaluation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InsId");

                    b.HasIndex("CrsId");

                    b.ToTable("InsCourse");
                });

            modelBuilder.Entity("Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("InsDegree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("DeptId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("StudCourse", b =>
                {
                    b.Property<int>("CrsID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StId")
                        .HasColumnType("int");

                    b.HasKey("CrsID");

                    b.HasIndex("StId");

                    b.ToTable("StudCourse");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("StAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StAge")
                        .HasColumnType("int");

                    b.Property<string>("StFname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StLname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StSuper")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.HasIndex("StSuper");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TopName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("topics");
                });

            modelBuilder.Entity("Course", b =>
                {
                    b.HasOne("Topic", "Top")
                        .WithMany("Courses")
                        .HasForeignKey("TopId");

                    b.Navigation("Top");
                });

            modelBuilder.Entity("Department", b =>
                {
                    b.HasOne("Instructor", null)
                        .WithMany("Departments")
                        .HasForeignKey("InstructorID");
                });

            modelBuilder.Entity("InsCourse", b =>
                {
                    b.HasOne("Course", "Crs")
                        .WithMany("InsCourses")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Instructor", "Ins")
                        .WithMany("InsCourses")
                        .HasForeignKey("InsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crs");

                    b.Navigation("Ins");
                });

            modelBuilder.Entity("Instructor", b =>
                {
                    b.HasOne("Department", "Dept")
                        .WithMany()
                        .HasForeignKey("DeptId");

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("StudCourse", b =>
                {
                    b.HasOne("Course", "Crs")
                        .WithMany("StudCourses")
                        .HasForeignKey("CrsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Student", "St")
                        .WithMany("Student_cources")
                        .HasForeignKey("StId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crs");

                    b.Navigation("St");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.HasOne("Department", "Dept")
                        .WithMany()
                        .HasForeignKey("DeptId");

                    b.HasOne("Student", "StSuperriolation")
                        .WithMany("Super_student")
                        .HasForeignKey("StSuper");

                    b.Navigation("Dept");

                    b.Navigation("StSuperriolation");
                });

            modelBuilder.Entity("Course", b =>
                {
                    b.Navigation("InsCourses");

                    b.Navigation("StudCourses");
                });

            modelBuilder.Entity("Instructor", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("InsCourses");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Navigation("Student_cources");

                    b.Navigation("Super_student");
                });

            modelBuilder.Entity("Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
