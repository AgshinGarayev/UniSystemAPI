using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.DTOS.InstructorDtos
{
    public record InstructorToListDto
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }

    }
}
