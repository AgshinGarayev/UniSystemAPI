using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.InstructorDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Abstract
{
    public interface IUniSystemInstructorService
    {
        public List<InstructorToListDto> GetAllInstructors();
        public void AddInstructor(InstructorToAddDto dto);
        public void UpdateInstructor(int id, InstructorToUpdateDto dto);
        public Instructor GetInstructorById(int id);
        public void DeleteInstructor(int id);
    }
}
