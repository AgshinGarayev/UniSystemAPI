using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DTOS.DepartmentDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Concrete
{
    public class UniSystemDepartmentManager : IUniSystemDepartmentService
    {
        private IUniSystemDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public UniSystemDepartmentManager(IUniSystemDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;

        }

        public void AddDepartment(DepartmentToAddDto dto)
        {
            var entity = _mapper.Map<Department>(dto);
            _departmentRepository.AddDepartment(entity);
        }

        public void DeleteDepartment(int id)
        {
            _departmentRepository.DeleteDepartment(id);
        }

        public List<DepartmentToListDto> GetAllDepartments()
        {
            var entities = _departmentRepository.GetAllDepartments();
            return _mapper.Map<List<DepartmentToListDto>>(entities);
        }

        public Department GetDepartmentById(int id)
        {
            return _departmentRepository.GetDepartmentById(id);
        }

        public void UpdateDepartment(int id, DepartmentToUpdateDto dto)
        {
           Department department = _mapper.Map<Department>(dto);
           department.DepartmentId= id;
           _departmentRepository.UpdateDepartment(department);


        }
    }
}
