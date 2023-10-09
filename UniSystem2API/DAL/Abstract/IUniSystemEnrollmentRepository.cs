using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Abstract { 
    public interface IUniSystemEnrollmentRepository
    {
        List<Enrollment> GetAllEnrollments();
        IEnumerable<Enrollment> GetEnrollmentsByStudentId(int studentId);
        IEnumerable<Enrollment> GetEnrollmentsByCourseId(int courseId);
        void EnrollStudentInCourse(int studentId, int courseId);
        void RemoveStudentFromCourse(int studentId, int courseId);
        public void UpdateEnrollment(Enrollment enrollment);
       

    }
}
