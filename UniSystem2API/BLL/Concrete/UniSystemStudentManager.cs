using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DTOS.StudentDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Concrete
{
    public class UniSystemStudentManager : IUniSystemStudentService
    {

        private IUniSystemStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public UniSystemStudentManager(IUniSystemStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;

        }
        

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

        

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public List<Student> GetStudentsWithUnpaidTuition()
        {
            return _studentRepository.GetStudentsWithUnpaidTuition();
        }

        public List<StudentToListDto> GetAllStudents()
        {
            var entities = _studentRepository.GetAllStudents();
            return _mapper.Map<List<StudentToListDto>>(entities);
        }

        public void AddStudent(StudentToAddDto dto)
        {
            var entity = _mapper.Map<Student>(dto);
            _studentRepository.AddStudent(entity);
        }

        public void UpdateStudent(int id, StudentToUpdateDto dto)
        {
            Student student = _mapper.Map<Student>(dto);
            student.StudentId= id;
            _studentRepository.UpdateStudent(student);  
        }
    }
}
