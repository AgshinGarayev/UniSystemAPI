using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DTOS.InstructorDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Concrete
{
    public class UniSystemInstructorManager : IUniSystemInstructorService
    {

        private IUniSystemInstructorRepository _instructorRepository;
        private readonly IMapper _mapper;

        public UniSystemInstructorManager(IUniSystemInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;

        }
      

        public void DeleteInstructor(int id)
        {
            _instructorRepository.DeleteInstructor(id);
        }

       

        public Instructor GetInstructorById(int id)
        {
            return _instructorRepository.GetInstructorById(id);
        }

        public List<InstructorToListDto> GetAllInstructors()
        {
            var entities = _instructorRepository.GetAllInstructors();
            return _mapper.Map<List<InstructorToListDto>>(entities);
        }

        public void AddInstructor(InstructorToAddDto dto)
        {
            var entity = _mapper.Map<Instructor>(dto);
            _instructorRepository.AddInstructor(entity);
        }

        void IUniSystemInstructorService.UpdateInstructor(int id, InstructorToUpdateDto dto)
        {
            Instructor instructor = _mapper.Map<Instructor>(dto);
            instructor.InstructorId = id;
            _instructorRepository.UpdateInstructor(instructor);
        }
    }
}
