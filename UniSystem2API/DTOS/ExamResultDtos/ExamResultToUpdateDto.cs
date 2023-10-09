using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.DTOS.ExamResultDtos
{
    public record ExamResultToUpdateDto
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public double Score { get; set; }
    }
}
