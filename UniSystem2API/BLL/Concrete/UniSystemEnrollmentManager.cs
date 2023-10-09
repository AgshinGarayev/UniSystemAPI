using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DTOS.EnrollmentDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Concrete
{
    public class UniSystemEnrollmentManager : IUniSystemEnrollmentService
    {
        private IUniSystemEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;

        public UniSystemEnrollmentManager(IUniSystemEnrollmentRepository enrollmentRepository, IMapper mapper)
        {
            _enrollmentRepository = enrollmentRepository;
            _mapper = mapper;

        }
        public void EnrollStudentInCourse(int studentId, int courseId)
        {
            _enrollmentRepository.EnrollStudentInCourse(studentId, courseId);
        }


        public IEnumerable<Enrollment> GetEnrollmentsByCourseId(int courseId)
        {
           return _enrollmentRepository.GetEnrollmentsByCourseId(courseId);
        }

        public IEnumerable<Enrollment> GetEnrollmentsByStudentId(int studentId)
        {
            return _enrollmentRepository.GetEnrollmentsByStudentId(studentId);
        }

        public void RemoveStudentFromCourse(int studentId, int courseId)
        {
            _enrollmentRepository.RemoveStudentFromCourse(studentId, courseId);
        }

        public List<EnrollmentToListDto> GetAllEnrollments()
        {
            var entities = _enrollmentRepository.GetAllEnrollments();
            return _mapper.Map<List<EnrollmentToListDto>>(entities);
        }

        public void UpdateEnrollment(int id, EnrollmentToUpdateDto dto)
        {
           Enrollment enrollment = _mapper.Map<Enrollment>(dto);
           enrollment.EnrollmentId = id;
           _enrollmentRepository.UpdateEnrollment(enrollment);
        }
    }
}
