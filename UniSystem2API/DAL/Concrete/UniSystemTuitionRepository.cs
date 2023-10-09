using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Concrete
{
    public class UniSystemTuitionRepository : IUniSystemTuitionRepository
    {

        private readonly UniDbContext _uniDbContext;

        public UniSystemTuitionRepository(UniDbContext dbContext)
        {
            _uniDbContext = dbContext;
        }
        public void AddTuition(Tuition tuition)
        {

            _uniDbContext.Tuitions.Add(tuition);
            _uniDbContext.SaveChanges();
               
           
        }

        public void DeleteTuition(int id)
        {
            
                var deletedTuition = _uniDbContext.Tuitions.Find(id);
                _uniDbContext.Tuitions.Remove(deletedTuition);
          
        }

        public List<Tuition> GetAllTuitions()
        {
           
          return _uniDbContext.Tuitions.ToList();
           
        }


        public Tuition GetTuitionById(int id)
        {
            
          return _uniDbContext.Tuitions.Find(id);
        
        }


        public void UpdateTuition(Tuition tuition)
        {
           
                _uniDbContext.Tuitions.Update(tuition);
                _uniDbContext.SaveChanges();
            

          
        }
    }
}
