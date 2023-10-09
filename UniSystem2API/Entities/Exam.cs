using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniSystem2API.Entities
{
    
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamId { get; set; }
        public int ExamType { get; set; }
        public string Location { get; set; }

        
        public int CourseId { get; set; } 
        public Course Course { get; set; } 

        
        public ICollection<ExamResult>? ExamResults { get; set; } 
    }
}
