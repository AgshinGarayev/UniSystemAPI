using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.Entities;
//using UniSystem.DataAccess.Core.Enums;


namespace UniSystem2API.DAL
{
    public class UniDbContext:DbContext
    {

        public UniDbContext(DbContextOptions<UniDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Exam>().HasData(
            //    new Exam()
            //    {
            //        ExamId = 1,
            //        ExamType= 1,//Midterms
            //        Location=EExam.SouthCampus.ToString(),
            //    },

            //    new Exam()
            //    {
            //        ExamId = 2,
            //        ExamType = 2,//Finals
            //        Location=EExam.NorthCampus.ToString(),
            //    }

            //    );
        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Tuition> Tuitions { get; set;}


    }
}
