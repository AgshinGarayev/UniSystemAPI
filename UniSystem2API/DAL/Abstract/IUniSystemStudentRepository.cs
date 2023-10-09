using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Abstract
{
    public interface IUniSystemStudentRepository
    {
        public List<Student> GetAllStudents();
        public void AddStudent(Student student);
        public void UpdateStudent(Student student);
        public Student GetStudentById(int id);
        public void DeleteStudent(int id);
        List<Student> GetStudentsWithUnpaidTuition();
    }
}
