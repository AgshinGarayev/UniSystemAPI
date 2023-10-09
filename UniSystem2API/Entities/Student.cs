using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem2API.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        
        public ICollection<Enrollment>? Enrollments { get; set; } 
        public ICollection<ExamResult>? ExamResults { get; set; } 
    }
}
