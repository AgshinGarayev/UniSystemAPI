using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.ExamDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Abstract
{
    public interface IUniSystemExamService
    {
        public List<ExamToListDto> GetAllExams();
        public void AddExam(ExamToAddDto dto);
        public void UpdateExam(int id, ExamToUpdateDto dto);
        public Exam GetExamById(int id);
        public void DeleteExam(int id);
        double CalculateAverageScoreForCourse(int courseId);
    }
}
