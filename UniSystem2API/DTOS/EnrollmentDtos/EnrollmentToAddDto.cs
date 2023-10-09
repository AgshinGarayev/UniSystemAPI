using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.DTOS.EnrollmentDtos
{
    public record EnrollmentToAddDto
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
