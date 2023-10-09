using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.ExamResultDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Abstract
{
    public interface IUniSystemExamResultService
    {
        public List<ExamResultToListDto> GetAllExamResults();
        public void AddExamResult(ExamResultToAddDto dto);
        public void UpdateExamResult(int id, ExamResultToUpdateDto dto);
        public ExamResult GetExamResultById(int id);
        public void DeleteExamResult(int id);
        IEnumerable<ExamResult> GetExamResultsForStudent(int studentId);
    }
}
