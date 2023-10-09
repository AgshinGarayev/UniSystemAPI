using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniSystem2API.Entities
{
    
    public class Tuition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TuitionId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }

        
        public int? StudentId { get; set; } 
        public Student? Student { get; set; } 
        public int? CourseId { get; set; } 
        public Course? Course { get; set; } 
    }
}
