

using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Abstract
{
    public interface IUniSystemCourseRepository
    {
        public List<Course> GetAllCourses();
        public void AddCourse(Course course);
        public void UpdateCourse(Course course);
        public Course GetCourseById(int id);
        public void DeleteCourse(int id);
        double CalculateCourseAverageScore(int courseId);
        IEnumerable<Exam> GetExamsForCourse(int courseId);
    }
}
