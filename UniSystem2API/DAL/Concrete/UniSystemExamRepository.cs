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
    public class UniSystemExamRepository : IUniSystemExamRepository
    {
        private readonly UniDbContext _uniDbContext;

        public UniSystemExamRepository(UniDbContext dbContext)
        {
            _uniDbContext = dbContext;
        }
        public void AddExam(Exam exam)
        {

            _uniDbContext.Exams.Add(exam);
            _uniDbContext.SaveChanges();
            
        }

        public double CalculateAverageScoreForCourse(int courseId)
        {
           
                
                var examResultsForCourse = _uniDbContext.ExamResults
                    .Where(result => result.Exam.CourseId == courseId)
                    .ToList(); 

                if (examResultsForCourse.Any())
                {
                    
                    double totalScore = examResultsForCourse.Sum(result => result.Score);
                    double averageScore = totalScore / examResultsForCourse.Count;
                    return averageScore;
                }
                else
                {
                    
                    throw new InvalidOperationException("No exam results found for the course.");
                }
            
        }

        public void DeleteExam(int id)
        {
           
                var deletedExam = _uniDbContext.Exams.Find(id);
                _uniDbContext.Exams.Remove(deletedExam);
           
        }

        public List<Exam> GetAllExams()
        {
                return _uniDbContext.Exams.ToList();
        }

        public Exam GetExamById(int id)
        {
            
                return _uniDbContext.Exams.Find(id);
        }

        public void UpdateExam(Exam exam)
        {

                _uniDbContext.Exams.Update(exam);
                _uniDbContext.SaveChanges();

            
        }
    }
}
