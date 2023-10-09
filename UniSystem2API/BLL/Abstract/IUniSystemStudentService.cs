using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.StudentDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Abstract
{
    public interface IUniSystemStudentService
    {
        public List<StudentToListDto> GetAllStudents();
        public void AddStudent(StudentToAddDto dto);
        public void UpdateStudent(int id, StudentToUpdateDto dto);
        public Student GetStudentById(int id);
        public void DeleteStudent(int id);
        List<Student> GetStudentsWithUnpaidTuition();
    }
}
