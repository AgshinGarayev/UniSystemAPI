using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniSystem2API.Entities
{
    
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; } 
        public string Title { get; set; }
        public string CourseCode { get; set; }

        
        public ICollection<Enrollment>? Enrollments { get; set; }
        public ICollection<Exam>? Exams { get; set; } 
    }
}
