using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.DTOS.ExamDtos
{
    public record ExamToUpdateDto
    {
        public int ExamType { get; set; }
        public string Location { get; set; }
    }
}
