using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Concrete
{
    public class UniSystemDepartmentRepository : IUniSystemDepartmentRepository
    {
        private readonly UniDbContext _uniDbContext;

        public UniSystemDepartmentRepository(UniDbContext dbContext)
        {
            _uniDbContext = dbContext;
        }
        public void AddDepartment(Department department)
        {

            _uniDbContext.Departments.Add(department);
            _uniDbContext.SaveChanges();
           
        }

        public void DeleteDepartment(int id)
        {
         
            var deletedDepartment = _uniDbContext.Departments.Find(id);
            _uniDbContext.Departments.Remove(deletedDepartment);
           
            
        }

        public List<Department> GetAllDepartments()
        {
           
            return _uniDbContext.Departments.ToList();
                      
        }

        public Department GetDepartmentById(int id)
        {
           
              return _uniDbContext.Departments.Find(id);
           
        }

        public void UpdateDepartment(Department department)
        {
                _uniDbContext.Departments.Update(department);
                _uniDbContext.SaveChanges();
                

           
        }
    }
}
