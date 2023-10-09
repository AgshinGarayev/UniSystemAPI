using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DTOS.ExamDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Concrete
{
    public class UniSystemExamManager : IUniSystemExamService
    {
        private IUniSystemExamRepository _examRepository;
        private readonly IMapper _mapper;

        public UniSystemExamManager(IUniSystemExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;

        }
     

        public double CalculateAverageScoreForCourse(int courseId)
        {
            return _examRepository.CalculateAverageScoreForCourse(courseId);
        }

        public void DeleteExam(int id)
        {
            _examRepository.DeleteExam(id);
        }

        public Exam GetExamById(int id)
        {
            return _examRepository.GetExamById(id);
        }

        public List<ExamToListDto> GetAllExams()
        {
            var entities = _examRepository.GetAllExams();
            return _mapper.Map<List<ExamToListDto>>(entities);
        }

        public void AddExam(ExamToAddDto dto)
        {
            var entity = _mapper.Map<Exam>(dto);
            _examRepository.AddExam(entity);
        }

        public void UpdateExam(int id, ExamToUpdateDto dto)
        {
            Exam exam = _mapper.Map<Exam>(dto);
            exam.ExamId = id;
            _examRepository.UpdateExam(exam);
        }
    }
}
