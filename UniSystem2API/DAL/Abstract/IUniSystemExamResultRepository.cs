using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Abstract
{
    public interface IUniSystemExamResultRepository
    {
        public List<ExamResult> GetAllExamResults();
        public void AddExamResult(ExamResult examResult);
        public void UpdateExamResult(ExamResult examResult);
        public ExamResult GetExamResultById(int id);
        public void DeleteExamResult(int id);
        IEnumerable<ExamResult> GetExamResultsForStudent(int studentId);
    }
}
