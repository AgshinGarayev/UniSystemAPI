using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Abstract
{
    public interface IUniSystemExamRepository
    {
        public List<Exam> GetAllExams();
        public void AddExam(Exam exam);
        public void UpdateExam(Exam exam);
        public Exam GetExamById(int id);
        public void DeleteExam(int id);
        double CalculateAverageScoreForCourse(int courseId);
    }
}
