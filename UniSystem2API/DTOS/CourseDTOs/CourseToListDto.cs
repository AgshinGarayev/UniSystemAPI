using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.DTOS.CourseDTOs
{
    public record CourseToListDto
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string CourseCode { get; set; }

    }
}
