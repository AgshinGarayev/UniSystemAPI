using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DTOS.ExamResultDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Concrete
{
    public class UniSystemExamResultManager : IUniSystemExamResultService
    {
        private IUniSystemExamResultRepository _examResultRepository;
        private readonly IMapper _mapper;

        public UniSystemExamResultManager(IUniSystemExamResultRepository examResultRepository, IMapper mapper)
        {
            _examResultRepository = examResultRepository;
            _mapper = mapper;

        }
       

        public void DeleteExamResult(int id)
        {
             _examResultRepository.DeleteExamResult(id);
        }

        

        public ExamResult GetExamResultById(int id)
        {
            return _examResultRepository.GetExamResultById(id);
        }

        public IEnumerable<ExamResult> GetExamResultsForStudent(int studentId)
        {
            return _examResultRepository.GetExamResultsForStudent(studentId);
        }

        public List<ExamResultToListDto> GetAllExamResults()
        {
            var entities = _examResultRepository.GetAllExamResults();
            return _mapper.Map<List<ExamResultToListDto>>(entities);
        }

        public void AddExamResult(ExamResultToAddDto dto)
        {
            var entity = _mapper.Map<ExamResult>(dto);
            _examResultRepository.AddExamResult(entity);
        }

        public void UpdateExamResult(int id, ExamResultToUpdateDto dto)
        {
            ExamResult ExamResult = _mapper.Map<ExamResult>(dto);
            ExamResult.ExamResultId = id;
            _examResultRepository.UpdateExamResult(ExamResult);
        }
    }
}
