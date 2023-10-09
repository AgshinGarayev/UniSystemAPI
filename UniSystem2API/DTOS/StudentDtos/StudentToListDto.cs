using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.DTOS.StudentDtos
{
    public record StudentToListDto
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
