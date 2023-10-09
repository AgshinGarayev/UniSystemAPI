using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.DepartmentDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Abstract
{
    public interface IUniSystemDepartmentService
    {
        public List<DepartmentToListDto> GetAllDepartments();
        public void AddDepartment(DepartmentToAddDto dto);
        public void UpdateDepartment(int id, DepartmentToUpdateDto dto);
        public Department GetDepartmentById(int id);
        public void DeleteDepartment(int id);
    }
}
