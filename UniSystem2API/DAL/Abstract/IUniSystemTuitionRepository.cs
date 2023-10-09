using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Abstract
{
    public interface IUniSystemTuitionRepository
    {
        public List<Tuition> GetAllTuitions();
        public void AddTuition(Tuition tuition);
        public void UpdateTuition(Tuition tuition);
        public Tuition GetTuitionById(int id);
        public void DeleteTuition(int id);
        

    }
}
