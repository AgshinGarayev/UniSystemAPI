using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.DTOS.TuitionDtos
{
    public record TuitionToListDto
    {
        public int TuitionId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }

    }
}
