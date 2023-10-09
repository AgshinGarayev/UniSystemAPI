using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.TuitionDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Abstract
{
    public interface IUniSystemTuitionService
    {
        public List<TuitionToListDto> GetAllTuitions();
        public void AddTuition(TuitionToAddDto dto);
        public void UpdateTuition(int id, TuitionToUpdateDto dto);
        public Tuition GetTuitionById(int id);
        public void DeleteTuition(int id);
    }
}
