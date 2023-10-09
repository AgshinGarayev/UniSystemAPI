using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Abstract
{
    public interface IUniSystemInstructorRepository
    {
        public List<Instructor> GetAllInstructors();
        public void AddInstructor(Instructor instructor);
        public void UpdateInstructor(Instructor instructor);
        public Instructor GetInstructorById(int id);
        public void DeleteInstructor(int id);
    }
}
