using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.EnrollmentDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Abstract
{
    public interface IUniSystemEnrollmentService
    {
        IEnumerable<Enrollment> GetEnrollmentsByStudentId(int studentId);//done
        IEnumerable<Enrollment> GetEnrollmentsByCourseId(int courseId);//done
        void EnrollStudentInCourse(int studentId, int courseId);//done
        void RemoveStudentFromCourse(int studentId, int courseId);//done
        public void UpdateEnrollment(int id, EnrollmentToUpdateDto dto);//done
        List<EnrollmentToListDto> GetAllEnrollments();//done
    }
}
