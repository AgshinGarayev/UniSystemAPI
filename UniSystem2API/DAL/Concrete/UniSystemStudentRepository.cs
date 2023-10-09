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
    public class UniSystemStudentRepository : IUniSystemStudentRepository
    {

        private readonly UniDbContext _uniDbContext;

        public UniSystemStudentRepository(UniDbContext dbContext)
        {
            _uniDbContext = dbContext;
        }
        public void AddStudent(Student student)
        {
            
                _uniDbContext.Students.Add(student);
                _uniDbContext.SaveChanges();
            
        }

        public void DeleteStudent(int id)
        {
           
                var deletedStudent = _uniDbContext.Students.Find(id);
                _uniDbContext.Students.Remove(deletedStudent);
            _uniDbContext.SaveChanges();
          
        }

        public List<Student> GetAllStudents()
        {
         return _uniDbContext.Students.Include(c => c.Enrollments).ToList();
        }

        public Student GetStudentById(int id)
        {
          return _uniDbContext.Students.Find(id);
        }

        public List<Student> GetStudentsWithUnpaidTuition()
        {
          
                var studentsWithUnpaidTuitionIds = _uniDbContext.Tuitions
                   .Where(tuition => !tuition.IsPaid)
                   .Select(tuition => tuition.StudentId)
                   .Distinct()
                   .ToList(); 

                
                var studentsWithUnpaidTuition = _uniDbContext.Students
                    .Where(student => studentsWithUnpaidTuitionIds.Contains(student.StudentId))
                    .ToList();

                return studentsWithUnpaidTuition;
          
        }

        public void UpdateStudent(Student student)
        {
           
                _uniDbContext.Students.Update(student);
                _uniDbContext.SaveChanges();

           
        }
    }
}
