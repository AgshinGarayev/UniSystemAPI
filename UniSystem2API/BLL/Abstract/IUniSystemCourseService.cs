using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.CourseDTOs;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Abstract
{
    public interface IUniSystemCourseService
    {
        public List<CourseToListDto> GetAllCourses();
        public void AddCourse(CourseToAddDto dto);
        public void UpdateCourse(int id, CourseToUpdateDto dto);
        public Course GetCourseById(int id);
        public void DeleteCourse(int id);
        double CalculateCourseAverageScore(int courseId);
        IEnumerable<Exam> GetExamsForCourse(int courseId);
    }
}
