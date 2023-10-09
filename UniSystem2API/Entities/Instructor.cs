using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniSystem2API.Entities
{
    
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstructorId { get; set; }
        public string Name { get; set; }

        
        public ICollection<Course>? Courses { get; set; } 
    }
}
