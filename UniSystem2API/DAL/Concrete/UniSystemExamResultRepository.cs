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
    public class UniSystemExamResultRepository : IUniSystemExamResultRepository
    {

        private readonly UniDbContext _uniDbContext;

        public UniSystemExamResultRepository(UniDbContext dbContext)
        {
            _uniDbContext = dbContext;
        }
        public void AddExamResult(ExamResult examResult)
        {
                _uniDbContext.ExamResults.Add(examResult);
                _uniDbContext.SaveChanges();
               
           
        }

        public void DeleteExamResult(int id)
        {
            
                var deletedResult = _uniDbContext.ExamResults.Find(id);
                _uniDbContext.ExamResults.Remove(deletedResult);
            
        }

        public List<ExamResult> GetAllExamResults()
        {
            
                return _uniDbContext.ExamResults.ToList();
            
        }

        public ExamResult GetExamResultById(int id)
        {

               return _uniDbContext.ExamResults.Find(id);
            
        }

        public IEnumerable<ExamResult> GetExamResultsForStudent(int studentId)
        {
           
                var examResultsForStudent = _uniDbContext.ExamResults
                    .Where(result => result.StudentId == studentId)
                    .ToList();

                return examResultsForStudent;

        }

        public void UpdateExamResult(ExamResult examResult)
        {
           
                _uniDbContext.ExamResults.Update(examResult);
                _uniDbContext.SaveChanges();
               
           
        }
    }
}
