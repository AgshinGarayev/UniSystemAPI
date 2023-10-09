using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Abstract
{
    public interface IUniSystemDepartmentRepository
    {
        public List<Department> GetAllDepartments();
        public void AddDepartment(Department department);
        public void UpdateDepartment(Department department);
        public Department GetDepartmentById(int id);
        public void DeleteDepartment(int id);
    }
}
