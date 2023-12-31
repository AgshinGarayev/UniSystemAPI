﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UniSystem2API.DAL;

#nullable disable

namespace UniSystem2API.Migrations
{
    [DbContext(typeof(UniDbContext))]
    [Migration("20231009065537_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UniSystem2API.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CourseId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ExamId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("ExamType")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ExamId");

                    b.HasIndex("CourseId");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            ExamId = 1,
                            ExamType = 1,
                            Location = "SouthCampus"
                        },
                        new
                        {
                            ExamId = 2,
                            ExamType = 2,
                            Location = "NorthCampus"
                        });
                });

            modelBuilder.Entity("UniSystem2API.Entities.ExamResult", b =>
                {
                    b.Property<int>("ExamResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ExamResultId"));

                    b.Property<int>("ExamId")
                        .HasColumnType("integer");

                    b.Property<double>("Score")
                        .HasColumnType("double precision");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("ExamResultId");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.ToTable("ExamResults");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InstructorId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Tuition", b =>
                {
                    b.Property<int>("TuitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TuitionId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int?>("CourseId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("boolean");

                    b.Property<int?>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("TuitionId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Tuitions");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Course", b =>
                {
                    b.HasOne("UniSystem2API.Entities.Department", null)
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("UniSystem2API.Entities.Instructor", null)
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Enrollment", b =>
                {
                    b.HasOne("UniSystem2API.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniSystem2API.Entities.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Exam", b =>
                {
                    b.HasOne("UniSystem2API.Entities.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("UniSystem2API.Entities.ExamResult", b =>
                {
                    b.HasOne("UniSystem2API.Entities.Exam", "Exam")
                        .WithMany("ExamResults")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniSystem2API.Entities.Student", "Student")
                        .WithMany("ExamResults")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Tuition", b =>
                {
                    b.HasOne("UniSystem2API.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("UniSystem2API.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Course", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Exams");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Department", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Exam", b =>
                {
                    b.Navigation("ExamResults");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Instructor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("UniSystem2API.Entities.Student", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("ExamResults");
                });
#pragma warning restore 612, 618
        }
    }
}
