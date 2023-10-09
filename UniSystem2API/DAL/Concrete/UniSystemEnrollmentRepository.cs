using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Concrete
{
    public class UniSystemEnrollmentRepository : IUniSystemEnrollmentRepository
    {

        private readonly UniDbContext _uniDbContext;

        public UniSystemEnrollmentRepository(UniDbContext dbContext)
        {
            _uniDbContext = dbContext;
        }
        public void EnrollStudentInCourse(int studentId, int courseId)
        {


                bool isEnrolled = _uniDbContext.Enrollments
                .Any(enrollment => enrollment.StudentId == studentId && enrollment.CourseId == courseId);

                if (!isEnrolled)
                {
                    var enrollment = new Enrollment
                    {
                        StudentId = studentId,
                        CourseId = courseId,
                    };


                _uniDbContext.Enrollments.Add(enrollment);

                _uniDbContext.SaveChanges();
                }

                else
                {
                    Console.WriteLine("student is already enrolled");
                }

            
           
        }


        public IEnumerable<Enrollment> GetEnrollmentsByCourseId(int courseId)
        {
            
                var enrollmentsForCourse = _uniDbContext.Enrollments
                    .Where(enrollment => enrollment.CourseId == courseId)
                    .ToList();

                return enrollmentsForCourse;
            

        }

        public IEnumerable<Enrollment> GetEnrollmentsByStudentId(int studentId)
        {

            var enrollmentsForCourse = _uniDbContext.Enrollments
                .Where(enrollment => enrollment.StudentId == studentId)
                .ToList();

            return enrollmentsForCourse;


        }

        public void RemoveStudentFromCourse(int studentId, int courseId)
        {
            
                var enrollmentToRemove = _uniDbContext.Enrollments
                    .SingleOrDefault(enrollment => enrollment.StudentId == studentId && enrollment.CourseId == courseId);

                if (enrollmentToRemove != null)
                {
                _uniDbContext.Enrollments.Remove(enrollmentToRemove);

                _uniDbContext.SaveChanges();
                }

           

        }

        public void UpdateEnrollment(Enrollment enrollment)
        {

            _uniDbContext.Enrollments.Update(enrollment);
            _uniDbContext.SaveChanges();
            


        }

        List<Enrollment> IUniSystemEnrollmentRepository.GetAllEnrollments()
        {
           
            return _uniDbContext.Enrollments.ToList();
           
        }
    }
}
