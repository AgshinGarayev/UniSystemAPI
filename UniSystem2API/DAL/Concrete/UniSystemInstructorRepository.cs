using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Concrete 
{ 
    public class UniSystemInstructorRepository : IUniSystemInstructorRepository
    {

        private readonly UniDbContext _uniDbContext;

        public UniSystemInstructorRepository(UniDbContext dbContext)
        {
            _uniDbContext = dbContext;
        }
        public void AddInstructor(Instructor instructor)
        {

            _uniDbContext.Instructors.Add(instructor);
            _uniDbContext.SaveChanges();
           
        }

        public void DeleteInstructor(int id)
        {
           
                var deletedInstructor = _uniDbContext.Instructors.Find(id);
            _uniDbContext.Instructors.Remove(deletedInstructor);
           
        }

        public List<Instructor> GetAllInstructors()
        {
          
                return _uniDbContext.Instructors.ToList();
          
        }

        public Instructor GetInstructorById(int id)
        {
           
                return _uniDbContext.Instructors.Find(id);
           
        }

        public void UpdateInstructor(Instructor instructor)
        {
           
                _uniDbContext.Instructors.Update(instructor);
                _uniDbContext.SaveChanges();

        }
    }
}
