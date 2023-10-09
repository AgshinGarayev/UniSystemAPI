using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniSystem2API.Entities
{
    
    public class ExamResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamResultId { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public double Score { get; set; }

        public Student? Student { get; set; } 
        public Exam? Exam { get; set; } 
    }
}
