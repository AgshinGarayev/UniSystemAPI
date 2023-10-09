using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DTOS.TuitionDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Concrete
{
    public class UniSystemTuitionManager : IUniSystemTuitionService
    {
        private IUniSystemTuitionRepository _tuitionRepository;
        private readonly IMapper _mapper;

        public UniSystemTuitionManager(IUniSystemTuitionRepository tuitionRepository, IMapper mapper)
        {
            _tuitionRepository = tuitionRepository;
            _mapper = mapper;

        }
       

        public void DeleteTuition(int id)
        {
            _tuitionRepository.DeleteTuition(id);
        }

        

        public Tuition GetTuitionById(int id)
        {
            return _tuitionRepository.GetTuitionById(id);
        }

        public List<TuitionToListDto> GetAllTuitions()
        {
           var entities= _tuitionRepository.GetAllTuitions();
            return _mapper.Map<List<TuitionToListDto>>(entities);
        }

        public void AddTuition(TuitionToAddDto dto)
        {
            var entity = _mapper.Map<Tuition>(dto);
            _tuitionRepository.AddTuition(entity);
        }

        public void UpdateTuition(int id, TuitionToUpdateDto dto)
        {
            Tuition tuition = _mapper.Map<Tuition>(dto);
            tuition.TuitionId = id;
            _tuitionRepository.UpdateTuition(tuition);
        }
    }
}
